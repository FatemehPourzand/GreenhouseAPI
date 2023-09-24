using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbScheduledApiCaller
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int FunctionId { get; set; }
        public bool IsEveryday { get; set; }
        public bool IsArrived { get; set; }
    }
}
