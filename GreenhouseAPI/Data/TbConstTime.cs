using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbConstTime
    {
        public int IdConstTime { get; set; }
        public int IdSchedule { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        public virtual TbSchedule IdScheduleNavigation { get; set; } = null!;
    }
}
