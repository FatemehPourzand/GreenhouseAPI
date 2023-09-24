using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class ViewSpDeviceIovaluePer24hour
    {
        public int IdDeviceIo { get; set; }
        public string EnNameIo { get; set; } = null!;
        public string FaNameIo { get; set; } = null!;
        public string? LogMonth { get; set; }
        public double? AvgValue { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }
    }
}
