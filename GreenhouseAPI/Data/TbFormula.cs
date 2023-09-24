using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbFormula
    {
        public TbFormula()
        {
            TbLogFormulas = new HashSet<TbLogFormula>();
        }

        public int IdFormula { get; set; }
        public int IdArea { get; set; }
        public string EnFormulaName { get; set; } = null!;
        public string FaFormulaName { get; set; } = null!;
        public string ExpressionFormula { get; set; } = null!;
        public double ResultFormula { get; set; }
        public TimeSpan TimeUpdate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual ICollection<TbLogFormula> TbLogFormulas { get; set; }
    }
}
