using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAlarmRole
    {
        public int IdAlarmRole { get; set; }
        public int IdAlarm { get; set; }
        public int IdRole { get; set; }

        public virtual TbAlarm IdAlarmNavigation { get; set; } = null!;
        public virtual TbRole IdRoleNavigation { get; set; } = null!;
    }
}
