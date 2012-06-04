using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }


        public override bool Equals(object obj)
        {
            var other = obj as Team;
            if (other == null)
                return false;
            
            if (object.ReferenceEquals(other, this))
                return true;

            return other.TeamId == this.TeamId;
        }

        public override int GetHashCode()
        {
            return TeamId.GetHashCode();
        }
    }
}