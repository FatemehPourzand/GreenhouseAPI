using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbTolerance
    {
        public TbTolerance()
        {
            TbLibraryDeviceInputOutputs = new HashSet<TbLibraryDeviceInputOutput>();
        }

        public int IdTolerance { get; set; }
        public string TittleTolerance { get; set; } = null!;
        public double ErrorCoefficient { get; set; }
        public double MaxT { get; set; }
        public double MinT { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<TbLibraryDeviceInputOutput> TbLibraryDeviceInputOutputs { get; set; }
    }
}
