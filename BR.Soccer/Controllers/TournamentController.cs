using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BR.Soccer.Models;
using BR.Soccer.Models.InputModels;
using BR.Soccer.Models.ViewModels;

namespace BR.Soccer.Controllers
{
    public class TournamentController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Tournament/

        public ActionResult Index()
        {
            return View(db.Tournaments.ToList());
        }

        //
        // GET: /Tournament/Details/5

        public ActionResult Details(int id = 0)
        {
            var tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }

            var viewModel = new TournamentViewModel
            {
                Name = tournament.Name
            };

            var stage = tournament.Stages.FirstOrDefault(s => s.Order == 1);
            var stageViewModel = new GroupStageViewModel
            {
                Name = stage.Name
            };

            var groupViewModels = new List<GroupViewModel>();
            var games = stage.Games;
            var groups = stage.Groups;
            foreach (var group in groups)
            {
                // If team 1 is in the group, then by necessity team 2 is in group as well, unless something has gone
                // horribly wrong
                var groupGames = from game in games
                                 where @group.Teams.Select(t => t.Team).Contains(game.Team1)
                                 select game;

                var teamStats = (from team in @group.Teams
                                 let stats = GetGroupEntry(team, groupGames)
                                 orderby stats.Points descending, stats.GoalDifference descending
                                 select stats).ToList();

                foreach (var stat in teamStats)
                {
                    IsClinched(stat, teamStats);
                }

                var results = from game in groupGames
                             select new GameResultViewModel
                             {
                                 Team1 = game.Team1.Name,
                                 Team2 = game.Team2.Name,
                                 Team1Score = game.Team1Score,
                                 Team2Score = game.Team2Score,
                                 Status = game.Status,
                                 GameId = game.GameId
                             };

                var groupViewModel = new GroupViewModel
                {
                    Name = group.Name,
                    TeamStandings = teamStats,
                    Results = results
                };

                groupViewModels.Add(groupViewModel);
            }
            stageViewModel.Groups = groupViewModels;

            viewModel.Stages = new List<StageViewModel> { stageViewModel };

            ViewBag.TournamentId = tournament.TournamentId;

            return View(viewModel);
        }

        // simple isclinched function
        private bool IsClinched(GroupEntryViewModel teamStat, IEnumerable<GroupEntryViewModel> standings)
        {
            int numLower = 0;
            foreach (var standing in standings)
            {
                if (standing.TeamName == teamStat.TeamName)
                    continue;

                int gamesLeft = 3 - standing.PlayedGames;
                int maxPoints = standing.Points + (3 * gamesLeft);
                if (teamStat.Points > maxPoints)
                    numLower++;
            }

            return teamStat.IsPromoted = numLower >= 2;
        }

        private GroupEntryViewModel GetGroupEntry(GroupTeam team, IEnumerable<Game> games)
        {
            var players = new List<string>();
            if (team.Player1 == null)
                players.Add("Computer");
            else
            {
                players.Add(team.Player1.Name);
                if (team.Player2 != null)
                    players.Add(team.Player2.Name);
            }

            var model = new GroupEntryViewModel
            {
                TeamName = team.Team.Name,
                PlayerNames = players,
            };

            foreach (var game in games.Where(g => g.Status != GameStatus.NotPlayed))
            {
                if (game.Team1.Equals(team.Team))
                    model = CalculateTeamStats(model, game.Team1Score, game.Team2Score);
                else if (game.Team2.Equals(team.Team))
                    model = CalculateTeamStats(model, game.Team2Score, game.Team1Score);
            }

            return model;
        }

        private GroupEntryViewModel CalculateTeamStats(GroupEntryViewModel model, int myTeamScore, int theirTeamScore)
        {
            model.GoalsFor += myTeamScore;
            model.GoalsAgainst += theirTeamScore;

            if (myTeamScore > theirTeamScore)
                model.Wins++;
            else if (myTeamScore == theirTeamScore)
                model.Draws++;
            else
                model.Losses++;

            return model;
        }

        //
        // GET: /Tournament/MatchResults

        public ActionResult MatchResults(int id, int tournamentId)
        {
            var model = new TournamentGameResult();
            model.GameId = id;
            model.TournamentId = tournamentId;

            var game = db.Games.Find(id);
            model.Team1Score = game.Team1Score;
            model.Team2Score = game.Team2Score;

            return View(model);
        }

        //
        // POST: /Tournament/MatchResults()

        [HttpPost]
        public ActionResult MatchResults(TournamentGameResult model)
        {
            var game = db.Games.Find(model.GameId);

            if (ModelState.IsValid)
            {
                game.Team1Score = model.Team1Score;
                game.Team2Score = model.Team2Score;
                game.Status = GameStatus.Played;

                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Details", new { id = model.TournamentId, admin = 1 });
            }

            return View(model);
        }

        //
        // GET: /Tournament/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tournament/Create

        [HttpPost]
        public ActionResult Create(Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                db.Tournaments.Add(tournament);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tournament);
        }

        //
        // GET: /Tournament/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        //
        // POST: /Tournament/Edit/5

        [HttpPost]
        public ActionResult Edit(Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tournament).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tournament);
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}