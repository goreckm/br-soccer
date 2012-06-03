using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models.ViewModels
{
    public class TournamentViewModel
    {
        public string Name { get; set; }
        public IEnumerable<StageViewModel> Stages { get; set; }
    }
}