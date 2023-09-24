using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbChainCondition
    {
        public int IdChainCondition { get; set; }
        public int IdCondition { get; set; }
        public bool? OperandChain { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbCondition IdConditionNavigation { get; set; } = null!;
    }
}
