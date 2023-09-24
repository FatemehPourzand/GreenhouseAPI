using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogDeviceInputOutput
    {
        public decimal IdLog { get; set; }
        public int IdDeviceIo { get; set; }
        public double LastValue { get; set; }
        public DateTime DateLog { get; set; }

        public virtual TbDeviceInputOutput IdDeviceIoNavigation { get; set; } = null!;
    }
}
