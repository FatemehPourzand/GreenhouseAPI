using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbCameraMotionDetection
    {
        public decimal IdMotionDetection { get; set; }
        public int IdCamera { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual TbCamera IdCameraNavigation { get; set; } = null!;
    }
}
