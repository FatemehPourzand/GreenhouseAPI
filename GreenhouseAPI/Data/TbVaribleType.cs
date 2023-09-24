using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbVaribleType
    {
        public TbVaribleType()
        {
            TbConditionIdVaribleTypeXNavigations = new HashSet<TbCondition>();
            TbConditionIdVaribleTypeYNavigations = new HashSet<TbCondition>();
            TbThenActions = new HashSet<TbThenAction>();
        }

        public int IdVaribleType { get; set; }
        public string IndexType { get; set; } = null!;
        public string EnTitleVaribleType { get; set; } = null!;
        public string FaTitleVaribleType { get; set; } = null!;
        public string? ImageIcon { get; set; }
        public bool IsActive { get; set; }
        public string TableName { get; set; } = null!;
        public string FildName { get; set; } = null!;
        public string FildId { get; set; } = null!;

        public virtual ICollection<TbCondition> TbConditionIdVaribleTypeXNavigations { get; set; }
        public virtual ICollection<TbCondition> TbConditionIdVaribleTypeYNavigations { get; set; }
        public virtual ICollection<TbThenAction> TbThenActions { get; set; }
    }
}
