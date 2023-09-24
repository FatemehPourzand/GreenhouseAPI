using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbState
    {
        public int IdState { get; set; }
        public string EnStateName { get; set; } = null!;
        public string FaStateName { get; set; } = null!;
        public int PriorityState { get; set; }
        public int IdStateGroup { get; set; }
        public string DescriptionState { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbStateGroup IdStateGroupNavigation { get; set; } = null!;
    }
}
