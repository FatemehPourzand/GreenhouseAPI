using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogGateway
    {
        public decimal IdLogGateway { get; set; }
        public int IdGateway { get; set; }
        public DateTime StartConnection { get; set; }
        public DateTime? EndConnection { get; set; }

        public virtual TbGateway IdGatewayNavigation { get; set; } = null!;
    }
}
