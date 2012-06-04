using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public class GroupTeam
    {
        [Key]
        public int GroupTeamId { get; set; }

        public virtual Team Team { get; set; }
        public virtual Player Player1 { get; set; }
        public virtual Player Player2 { get; set; }
    }
}