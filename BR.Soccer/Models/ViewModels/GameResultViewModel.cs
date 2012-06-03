using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models.ViewModels
{
    public class GameResultViewModel
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        
        public IHtmlString ResultFormatted 
        {
            get
            {
                if (Status == GameStatus.NotPlayed)
                    return new HtmlString("VS");

                return new HtmlString(Team1Score + "-" + Team2Score);
            }
        }

        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        public GameStatus Status { get; set; }
        public int GameId { get; set; }
    }
}