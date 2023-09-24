using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbIntervalGroup
    {
        public TbIntervalGroup()
        {
            TbIntervalSubs = new HashSet<TbIntervalSub>();
        }

        public int IdIntervalGroup { get; set; }
        public string FaIntervalGroupName { get; set; } = null!;
        public string EnIntervalGroupName { get; set; } = null!;

        public virtual ICollection<TbIntervalSub> TbIntervalSubs { get; set; }
    }
}
