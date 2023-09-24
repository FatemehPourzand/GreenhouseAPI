using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAlarmPriority
    {
        public TbAlarmPriority()
        {
            TbAlarms = new HashSet<TbAlarm>();
        }

        public int IdPriority { get; set; }
        public string EnName { get; set; } = null!;
        public string FaName { get; set; } = null!;
        public TimeSpan AllowedPostingIntervalFrom { get; set; }
        public TimeSpan AllowedPostingIntervalTo { get; set; }
        public int PriorityValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<TbAlarm> TbAlarms { get; set; }
    }
}
