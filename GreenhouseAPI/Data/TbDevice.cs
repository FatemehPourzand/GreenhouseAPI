using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbDevice
    {
        public TbDevice()
        {
            TbCameras = new HashSet<TbCamera>();
            TbDeviceInputOutputs = new HashSet<TbDeviceInputOutput>();
            TbDeviceTags = new HashSet<TbDeviceTag>();
            TbLogDevices = new HashSet<TbLogDevice>();
        }

        public int IdDevice { get; set; }
        public int IdGateway { get; set; }
        public int IdLibDevice { get; set; }
        public string LastPayload { get; set; } = null!;
        public bool Fault { get; set; }
        public string FaName { get; set; } = null!;
        public string EnName { get; set; } = null!;
        public float Lat { get; set; }
        public float Long { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbGateway IdGatewayNavigation { get; set; } = null!;
        public virtual TbDeviceLibrary IdLibDeviceNavigation { get; set; } = null!;
        public virtual ICollection<TbCamera> TbCameras { get; set; }
        public virtual ICollection<TbDeviceInputOutput> TbDeviceInputOutputs { get; set; }
        public virtual ICollection<TbDeviceTag> TbDeviceTags { get; set; }
        public virtual ICollection<TbLogDevice> TbLogDevices { get; set; }
    }
}
