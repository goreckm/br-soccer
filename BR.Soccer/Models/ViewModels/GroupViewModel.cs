using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BR.Soccer.Models.ViewModels
{
    public class GroupViewModel
    {
        public string Name { get; set; }
        public IEnumerable<GroupEntryViewModel> TeamStandings { get; set; }
        public IEnumerable<GameResultViewModel> Results { get; set; }
    }
}
