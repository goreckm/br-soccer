using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        public string Name { get; set; }
        public virtual ICollection<MatchTeam> Teams { get; set; }
    }
}