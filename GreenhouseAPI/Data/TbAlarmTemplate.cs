using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAlarmTemplate
    {
        public int IdTemplate { get; set; }
        public string AlarmMessage { get; set; } = null!;
        public string TemName { get; set; } = null!;
        public string? FaDisplayName { get; set; }
    }
}
