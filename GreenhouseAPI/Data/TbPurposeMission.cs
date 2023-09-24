using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbPurposeMission
    {
        public decimal IpPurposeMission { get; set; }
        public decimal IdMission { get; set; }
        public int IdPurpose { get; set; }
        public string TittlePm { get; set; } = null!;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbMission IdMissionNavigation { get; set; } = null!;
        public virtual TbPurpose IdPurposeNavigation { get; set; } = null!;
    }
}
