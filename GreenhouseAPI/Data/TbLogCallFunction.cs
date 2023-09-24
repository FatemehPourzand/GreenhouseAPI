using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogCallFunction
    {
        public decimal IdLogCallFunction { get; set; }
        public int IdFunction { get; set; }
        public int? IdCallerFunction { get; set; }
        public int? IdCancellerFunction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal? TotalTimePerSecond { get; set; }
        public decimal? RemainTimePerSecond { get; set; }
        public bool IsFinish { get; set; }
        public bool IsCancel { get; set; }

        public virtual TbFunction? IdCallerFunctionNavigation { get; set; }
        public virtual TbFunction? IdCancellerFunctionNavigation { get; set; }
        public virtual TbFunction IdFunctionNavigation { get; set; } = null!;
    }
}
