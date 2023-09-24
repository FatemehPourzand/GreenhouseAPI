using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbPurpose
    {
        public TbPurpose()
        {
            TbPurposeMissions = new HashSet<TbPurposeMission>();
        }

        public int IdPurpose { get; set; }
        public string TittlePurpose { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<TbPurposeMission> TbPurposeMissions { get; set; }
    }
}
