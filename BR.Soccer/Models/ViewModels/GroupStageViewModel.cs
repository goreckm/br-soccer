using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models.ViewModels
{
    public class GroupStageViewModel : StageViewModel
    {
        public IEnumerable<GroupViewModel> Groups { get; set; }
    }
}