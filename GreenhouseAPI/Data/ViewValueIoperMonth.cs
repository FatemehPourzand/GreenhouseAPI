using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class ViewValueIoperMonth
    {
        public int IdDeviceIo { get; set; }
        public string EnNameIo { get; set; } = null!;
        public string FaNameIo { get; set; } = null!;
        public string? LogYear { get; set; }
        public string? LogMonth { get; set; }
        public double? AvgValue { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }
    }
}
