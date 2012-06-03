using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public enum TournamentStatus { InProgress, Finished }

    public class Tournament
    {
        [Key]
        public int TournamentId { get; set; }

        public string Name { get; set; }

        public TournamentStatus Status { get; set; }
        public int StatusVal
        {
            get { return (int)Status; }
            set { Status = (TournamentStatus)value; }
        }

        public virtual ICollection<Stage> Stages { get; set; }
    }
}