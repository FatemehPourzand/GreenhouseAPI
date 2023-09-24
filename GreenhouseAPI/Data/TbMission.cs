using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbMission
    {
        public TbMission()
        {
            TbPurposeMissions = new HashSet<TbPurposeMission>();
        }

        public decimal IdMission { get; set; }
        public int IdAgent { get; set; }
        public DateTime DateMission { get; set; }
        public decimal LoginCode { get; set; }
        public bool IsFinish { get; set; }
        public bool Announce { get; set; }
        public int IdTower { get; set; }
        public string? UserEscort { get; set; }

        public virtual TbAgent IdAgentNavigation { get; set; } = null!;
        public virtual TbTower IdTowerNavigation { get; set; } = null!;
        public virtual ICollection<TbPurposeMission> TbPurposeMissions { get; set; }
    }
}
