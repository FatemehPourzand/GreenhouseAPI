using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbUser
    {
        public TbUser()
        {
            TbDashboards = new HashSet<TbDashboard>();
            TbFunctions = new HashSet<TbFunction>();
            TbLogModifyFunctions = new HashSet<TbLogModifyFunction>();
            TbLogUsers = new HashSet<TbLogUser>();
        }

        public int IdUser { get; set; }
        public string Uname { get; set; } = null!;
        public string Upass { get; set; } = null!;
        public int IdRole { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public string Tel { get; set; } = null!;
        public bool IsEnable { get; set; }
        public DateTime RegisterAt { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual TbRole IdRoleNavigation { get; set; } = null!;
        public virtual ICollection<TbDashboard> TbDashboards { get; set; }
        public virtual ICollection<TbFunction> TbFunctions { get; set; }
        public virtual ICollection<TbLogModifyFunction> TbLogModifyFunctions { get; set; }
        public virtual ICollection<TbLogUser> TbLogUsers { get; set; }
    }
}
