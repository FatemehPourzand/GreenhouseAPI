using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbDeviceIotag
    {
        public int IdDeviceIotag { get; set; }
        public string EnNameIotag { get; set; } = null!;
        public string FaNameIotag { get; set; } = null!;
        public int IdLibInputOutput { get; set; }
        public int IdDeviceTag { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbDeviceTag IdDeviceTagNavigation { get; set; } = null!;
        public virtual TbLibraryDeviceInputOutput IdLibInputOutputNavigation { get; set; } = null!;
    }
}
