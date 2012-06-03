using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models.ViewModels
{
    public class GroupEntryViewModel
    {
        public string TeamName { get; set; }
        public IEnumerable<string> PlayerNames { get; set; }

        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public bool IsPromoted { get; set; }


        public IHtmlString DisplayName
        {
            get
            {
                var playerNames = string.Join(" & ", PlayerNames);
                return new HtmlString(TeamName + " " + "<span>(" + playerNames + ")</span>");
            }
        }

        public int PlayedGames
        {
            get { return Wins + Draws + Losses; }
        }

        public int Points
        {
            get { return Wins * 3 + Draws; }
        }

        public int GoalDifference
        {
            get { return GoalsFor - GoalsAgainst; }
        }

        public IHtmlString GoalDifferenceFormatted
        {
            get
            {
                return new HtmlString(GoalDifference <= 0 ? GoalDifference.ToString() : "+" + GoalDifference.ToString());
            }
        }

        public string RowClass
        {
            get { return IsPromoted ? "q" : null; }
        }
    }
}