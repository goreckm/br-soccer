using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models.InputModels
{
    public class TournamentGameResult
    {
        public int GameId { get; set; }
        public int TournamentId { get; set; }

        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
    }
}