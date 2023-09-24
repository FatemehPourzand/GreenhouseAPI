using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbRole
    {
        public TbRole()
        {
            TbAccessRoles = new HashSet<TbAccessRole>();
            TbAlarmRoles = new HashSet<TbAlarmRole>();
            TbUsers = new HashSet<TbUser>();
        }

        public int IdRole { get; set; }
        public int IdArea { get; set; }
        public string EnTittle { get; set; } = null!;
        public string FaTittle { get; set; } = null!;
        public bool IsActive { get; set; }
        public string RoleDescription { get; set; } = null!;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string FileStyle { get; set; } = null!;

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual ICollection<TbAccessRole> TbAccessRoles { get; set; }
        public virtual ICollection<TbAlarmRole> TbAlarmRoles { get; set; }
        public virtual ICollection<TbUser> TbUsers { get; set; }
    }
}
