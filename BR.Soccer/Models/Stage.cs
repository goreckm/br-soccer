using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BR.Soccer.Models
{
    public enum StageType { Group }
    public enum StageStatus { NotStarted, InProgress, Finished }

    public class Stage
    {
        [Key]
        public int StageId { get; set; }

        public string Name { get; set; }
        public int Order { get; set; }

        public StageType Type { get; set; }
        public int TypeVal
        {
            get { return (int)Type; }
            set { Type = (StageType)value; }
        }

        public StageStatus Status { get; set; }
        public int StatusVal
        {
            get { return (int)Status; }
            set { Status = (StageStatus)value; }
        }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}