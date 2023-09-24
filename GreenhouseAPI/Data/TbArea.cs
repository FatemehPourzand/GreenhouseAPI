using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbArea
    {
        public TbArea()
        {
            TbAlarms = new HashSet<TbAlarm>();
            TbAreaEnvironments = new HashSet<TbAreaEnvironment>();
            TbFormulas = new HashSet<TbFormula>();
            TbFunctions = new HashSet<TbFunction>();
            TbGateways = new HashSet<TbGateway>();
            TbLicences = new HashSet<TbLicence>();
            TbRoles = new HashSet<TbRole>();
            TbStateGroups = new HashSet<TbStateGroup>();
        }

        public int IdArea { get; set; }
        public string NameFa { get; set; } = null!;
        public string NameEn { get; set; } = null!;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }
        public string? ImageIcon { get; set; }
        public string? ImageArea { get; set; }

        public virtual ICollection<TbAlarm> TbAlarms { get; set; }
        public virtual ICollection<TbAreaEnvironment> TbAreaEnvironments { get; set; }
        public virtual ICollection<TbFormula> TbFormulas { get; set; }
        public virtual ICollection<TbFunction> TbFunctions { get; set; }
        public virtual ICollection<TbGateway> TbGateways { get; set; }
        public virtual ICollection<TbLicence> TbLicences { get; set; }
        public virtual ICollection<TbRole> TbRoles { get; set; }
        public virtual ICollection<TbStateGroup> TbStateGroups { get; set; }
    }
}
