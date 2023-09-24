using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAlarmGroup
    {
        public TbAlarmGroup()
        {
            TbAlarms = new HashSet<TbAlarm>();
        }

        public int AlarmGroupId { get; set; }
        public string EnName { get; set; } = null!;
        public string FaName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<TbAlarm> TbAlarms { get; set; }
    }
}
