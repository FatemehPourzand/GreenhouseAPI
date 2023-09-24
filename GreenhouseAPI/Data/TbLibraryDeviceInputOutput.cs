using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLibraryDeviceInputOutput
    {
        public TbLibraryDeviceInputOutput()
        {
            TbDeviceInputOutputs = new HashSet<TbDeviceInputOutput>();
            TbDeviceIotags = new HashSet<TbDeviceIotag>();
        }

        public int IdLibInputOutput { get; set; }
        public string LibNameFa { get; set; } = null!;
        public string LibNameEn { get; set; } = null!;
        public string? ImageIcon { get; set; }
        public int IdLibType { get; set; }
        public int IdUnit { get; set; }
        public int IdTolerance { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDigit { get; set; }

        public virtual TbLibraryType IdLibTypeNavigation { get; set; } = null!;
        public virtual TbTolerance IdToleranceNavigation { get; set; } = null!;
        public virtual TbUnit IdUnitNavigation { get; set; } = null!;
        public virtual ICollection<TbDeviceInputOutput> TbDeviceInputOutputs { get; set; }
        public virtual ICollection<TbDeviceIotag> TbDeviceIotags { get; set; }
    }
}
