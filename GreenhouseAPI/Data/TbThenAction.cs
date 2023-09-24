using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbThenAction
    {
        public int IdThenAction { get; set; }
        public decimal IdVariable { get; set; }
        public int IdVaribleType { get; set; }
        public decimal? ForTime { get; set; }
        public int IdOperator { get; set; }
        public string? Value { get; set; }
        public int IdFunction { get; set; }

        public virtual TbFunction IdFunctionNavigation { get; set; } = null!;
        public virtual TbOperator IdOperatorNavigation { get; set; } = null!;
        public virtual TbVaribleType IdVaribleTypeNavigation { get; set; } = null!;
    }
}
