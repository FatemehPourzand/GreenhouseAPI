using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class ViewDeviceInputOutputLib
    {
        public string EnNameIo { get; set; } = null!;
        public string FaNameIo { get; set; } = null!;
        public int IdDeviceIo { get; set; }
        public int IdLibInputOutput { get; set; }
        public double LastValue { get; set; }
        public string LibNameFa { get; set; } = null!;
        public string LibNameEn { get; set; } = null!;
        public int IdLibType { get; set; }
        public int IdUnit { get; set; }
        public bool IsActive { get; set; }
        public string? ImageIcon { get; set; }
    }
}
