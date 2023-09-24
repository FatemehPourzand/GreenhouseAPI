using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogUser
    {
        public int IdLogUser { get; set; }
        public int IdUser { get; set; }
        public bool IsLogin { get; set; }
        public DateTime LastLoginTime { get; set; }

        public virtual TbUser IdUserNavigation { get; set; } = null!;
    }
}
