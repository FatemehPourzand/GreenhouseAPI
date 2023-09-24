using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbCondition
    {
        public TbCondition()
        {
            TbChainConditions = new HashSet<TbChainCondition>();
        }

        public int IdCondition { get; set; }
        public int IdFunction { get; set; }
        public decimal IdVariableX { get; set; }
        public int IdVaribleTypeX { get; set; }
        public decimal? IdVariableY { get; set; }
        public int? IdVaribleTypeY { get; set; }
        public decimal? ForTime { get; set; }
        public int IdOperator { get; set; }
        public string? Value { get; set; }

        public virtual TbFunction IdFunctionNavigation { get; set; } = null!;
        public virtual TbOperator IdOperatorNavigation { get; set; } = null!;
        public virtual TbVaribleType IdVaribleTypeXNavigation { get; set; } = null!;
        public virtual TbVaribleType? IdVaribleTypeYNavigation { get; set; }
        public virtual ICollection<TbChainCondition> TbChainConditions { get; set; }
    }
}
