using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbGateway
    {
        public TbGateway()
        {
            TbDevices = new HashSet<TbDevice>();
            TbLogGateways = new HashSet<TbLogGateway>();
        }

        public int IdGateway { get; set; }
        public int IdArea { get; set; }
        public string TopicGateway { get; set; } = null!;
        public string EnGatewayName { get; set; } = null!;
        public string FaGatewayName { get; set; } = null!;
        public double Lat { get; set; }
        public double Long { get; set; }
        public bool GatewayEndNode { get; set; }
        public int PeriodicCheckSecond { get; set; }
        public string? SimcardNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual ICollection<TbDevice> TbDevices { get; set; }
        public virtual ICollection<TbLogGateway> TbLogGateways { get; set; }
    }
}
