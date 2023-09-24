using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogFormula
    {
        public int IdLog { get; set; }
        public int IdFormula { get; set; }
        public double ResultLog { get; set; }
        public DateTime DateLog { get; set; }

        public virtual TbFormula IdFormulaNavigation { get; set; } = null!;
    }
}
