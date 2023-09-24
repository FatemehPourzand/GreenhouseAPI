using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAlarm
    {
        public TbAlarm()
        {
            TbAlarmRoles = new HashSet<TbAlarmRole>();
            TbLogAlarms = new HashSet<TbLogAlarm>();
        }

        public int IdAlarm { get; set; }
        public int IdArea { get; set; }
        public int IdTemplate { get; set; }
        public string EnAlarmName { get; set; } = null!;
        public string FaAlarmName { get; set; } = null!;
        public int IdPriority { get; set; }
        public int AlarmGroupId { get; set; }
        public bool SendSms { get; set; }
        public bool SendMail { get; set; }
        public bool VoiceCall { get; set; }
        public bool SendNotification { get; set; }
        public bool SendOther { get; set; }
        public int IntervalAlarmPerSecond { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbAlarmGroup AlarmGroup { get; set; } = null!;
        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual TbAlarmPriority IdPriorityNavigation { get; set; } = null!;
        public virtual ICollection<TbAlarmRole> TbAlarmRoles { get; set; }
        public virtual ICollection<TbLogAlarm> TbLogAlarms { get; set; }
    }
}
