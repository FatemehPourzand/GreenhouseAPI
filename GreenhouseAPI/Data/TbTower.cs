using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbTower
    {
        public TbTower()
        {
            TbMissions = new HashSet<TbMission>();
        }

        public int IdTower { get; set; }
        public string EnName { get; set; } = null!;
        public string FaName { get; set; } = null!;
        public decimal SiteNumber { get; set; }
        public string CellNumber { get; set; } = null!;
        public float Lat { get; set; }
        public float Long { get; set; }
        public bool IsEnable { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<TbMission> TbMissions { get; set; }
    }
}
