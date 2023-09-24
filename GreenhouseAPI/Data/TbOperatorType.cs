using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbOperatorType
    {
        public TbOperatorType()
        {
            TbOperators = new HashSet<TbOperator>();
        }

        public int IdOperatorType { get; set; }
        public string EnTitleOperatorType { get; set; } = null!;
        public string FaTitleOperatorType { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<TbOperator> TbOperators { get; set; }
    }
}
