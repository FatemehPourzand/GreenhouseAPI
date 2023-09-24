using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbOperator
    {
        public TbOperator()
        {
            TbConditions = new HashSet<TbCondition>();
            TbThenActions = new HashSet<TbThenAction>();
        }

        public int IdOperator { get; set; }
        public int IdOperatorType { get; set; }
        public string EnTitleOperator { get; set; } = null!;
        public string FaTitleOperator { get; set; } = null!;
        public string OperatorSign { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual TbOperatorType IdOperatorTypeNavigation { get; set; } = null!;
        public virtual ICollection<TbCondition> TbConditions { get; set; }
        public virtual ICollection<TbThenAction> TbThenActions { get; set; }
    }
}
