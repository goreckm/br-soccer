using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public enum GameStatus { NotPlayed, Played, Forfeit }

    public class Game
    {
        [Key]
        public int GameId { get; set; }

        public virtual Team Team1 { get; set; }
        public virtual Player Team1Player1 { get; set; }
        public virtual Player Team1Player2 { get; set; }
        public int Team1Score { get; set; }
        public int Team1ScorePen { get; set; }

        public virtual Team Team2 { get; set; }
        public virtual Player Team2Player1 { get; set; }
        public virtual Player Team2Player2 { get; set; }
        public int Team2Score { get; set; }
        public int Team2ScorePen { get; set; }

        public bool IsOT { get; set; }

        public GameStatus Status { get; set; }
        public int StatusVal
        {
            get { return (int)Status; }
            set { Status = (GameStatus)value; }
        }

        public virtual Stage Stage { get; set; }
    }
}