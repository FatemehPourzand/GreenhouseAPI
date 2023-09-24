using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbCamera
    {
        public TbCamera()
        {
            TbCameraImageStorages = new HashSet<TbCameraImageStorage>();
            TbCameraMotionDetections = new HashSet<TbCameraMotionDetection>();
        }

        public int IdCamera { get; set; }
        public int IdDevice { get; set; }
        public string EnCameraName { get; set; } = null!;
        public string FaCameraName { get; set; } = null!;
        public string CameraIp { get; set; } = null!;
        public string UserCamera { get; set; } = null!;
        public string PassCamera { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbDevice IdDeviceNavigation { get; set; } = null!;
        public virtual ICollection<TbCameraImageStorage> TbCameraImageStorages { get; set; }
        public virtual ICollection<TbCameraMotionDetection> TbCameraMotionDetections { get; set; }
    }
}
