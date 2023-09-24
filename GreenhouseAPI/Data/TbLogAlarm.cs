using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogAlarm
    {
        public decimal IdLogAlarm { get; set; }
        public int IdAlarm { get; set; }
        public DateTime StartTime { get; set; }
        public string? Token1 { get; set; }
        public string? Token2 { get; set; }
        public string? Token3 { get; set; }
        public bool Deliver { get; set; }
        public bool IsRead { get; set; }
        public bool IsClear { get; set; }

        public virtual TbAlarm IdAlarmNavigation { get; set; } = null!;
    }
}
