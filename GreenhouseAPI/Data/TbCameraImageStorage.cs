using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbCameraImageStorage
    {
        public decimal IdImageStorage { get; set; }
        public int IdCamera { get; set; }
        public byte[] ImageFrame { get; set; } = null!;
        public DateTime StorageDate { get; set; }

        public virtual TbCamera IdCameraNavigation { get; set; } = null!;
    }
}
