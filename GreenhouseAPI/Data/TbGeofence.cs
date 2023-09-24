using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbGeofence
    {
        public int IdGeofence { get; set; }
        public string EnGeofenceName { get; set; } = null!;
        public string FaGeofenceName { get; set; } = null!;
        public double Lat { get; set; }
        public double Long { get; set; }
        public double Radius { get; set; }
    }
}
