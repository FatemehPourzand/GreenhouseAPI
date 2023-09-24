using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbDeviceInputOutput
    {
        public TbDeviceInputOutput()
        {
            TbLogDeviceInputOutputs = new HashSet<TbLogDeviceInputOutput>();
        }

        public int IdDeviceIo { get; set; }
        public string EnNameIo { get; set; } = null!;
        public string FaNameIo { get; set; } = null!;
        public int IdDevice { get; set; }
        public int IdLibInputOutput { get; set; }
        public string PortName { get; set; } = null!;
        public double LastValue { get; set; }
        public bool IsFault { get; set; }
        public string GroupName { get; set; } = null!;
        public int PriorityOn { get; set; }
        public int PriorityOff { get; set; }

        public virtual TbDevice IdDeviceNavigation { get; set; } = null!;
        public virtual TbLibraryDeviceInputOutput IdLibInputOutputNavigation { get; set; } = null!;
        public virtual ICollection<TbLogDeviceInputOutput> TbLogDeviceInputOutputs { get; set; }
    }
}
