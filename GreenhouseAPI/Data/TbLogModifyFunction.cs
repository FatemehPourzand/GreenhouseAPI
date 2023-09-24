using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogModifyFunction
    {
        public int IdLogModifyFunction { get; set; }
        public int IdFunction { get; set; }
        public int IdUser { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActiveChangedTo { get; set; }

        public virtual TbFunction IdFunctionNavigation { get; set; } = null!;
        public virtual TbUser IdUserNavigation { get; set; } = null!;
    }
}
