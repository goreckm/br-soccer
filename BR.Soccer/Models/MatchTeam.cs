using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BR.Soccer.Models
{
    public class MatchTeam
    {
        [Key]
        public int MatchTeamId { get; set; }

        public virtual Team Team { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
