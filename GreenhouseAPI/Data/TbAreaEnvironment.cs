using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAreaEnvironment
    {
        public int IdEnvironment { get; set; }
        public int IdArea { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
    }
}
