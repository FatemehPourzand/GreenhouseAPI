using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbInterval
    {
        public int IdInterval { get; set; }
        public int IdSchedule { get; set; }
        public int IdIntervalSub { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan FinishTime { get; set; }

        public virtual TbIntervalSub IdIntervalSubNavigation { get; set; } = null!;
        public virtual TbSchedule IdScheduleNavigation { get; set; } = null!;
    }
}
