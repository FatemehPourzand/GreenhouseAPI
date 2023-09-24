using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogDevice
    {
        public decimal IdLog { get; set; }
        public int IdDevice { get; set; }
        public bool DeviceStatus { get; set; }
        public string Payload { get; set; } = null!;
        public DateTime DateLog { get; set; }

        public virtual TbDevice IdDeviceNavigation { get; set; } = null!;
    }
}
