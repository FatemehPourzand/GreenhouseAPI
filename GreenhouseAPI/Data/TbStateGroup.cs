using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbStateGroup
    {
        public TbStateGroup()
        {
            TbStates = new HashSet<TbState>();
        }

        public int IdStateGroup { get; set; }
        public int IdArea { get; set; }
        public string EnTitleGroupState { get; set; } = null!;
        public string FaTitleGroupState { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual ICollection<TbState> TbStates { get; set; }
    }
}
