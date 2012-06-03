using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        public string Name { get; set; }
    }
}