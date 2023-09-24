using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbFunction
    {
        public TbFunction()
        {
            TbConditions = new HashSet<TbCondition>();
            TbLogCallFunctionIdCallerFunctionNavigations = new HashSet<TbLogCallFunction>();
            TbLogCallFunctionIdCancellerFunctionNavigations = new HashSet<TbLogCallFunction>();
            TbLogCallFunctionIdFunctionNavigations = new HashSet<TbLogCallFunction>();
            TbLogModifyFunctions = new HashSet<TbLogModifyFunction>();
            TbSchedules = new HashSet<TbSchedule>();
            TbThenActions = new HashSet<TbThenAction>();
        }

        public int IdFunction { get; set; }
        public int IdArea { get; set; }
        public string EnFunctionName { get; set; } = null!;
        public string FaFunctionName { get; set; } = null!;
        public DateTime CreateAt { get; set; }
        public int IdUserCreator { get; set; }
        public bool IsActive { get; set; }
        public bool IsRunning { get; set; }
        public bool IsFault { get; set; }
        public string GroupFunc { get; set; } = null!;
        public int PriorityOn { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
        public virtual TbUser IdUserCreatorNavigation { get; set; } = null!;
        public virtual ICollection<TbCondition> TbConditions { get; set; }
        public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdCallerFunctionNavigations { get; set; }
        public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdCancellerFunctionNavigations { get; set; }
        public virtual ICollection<TbLogCallFunction> TbLogCallFunctionIdFunctionNavigations { get; set; }
        public virtual ICollection<TbLogModifyFunction> TbLogModifyFunctions { get; set; }
        public virtual ICollection<TbSchedule> TbSchedules { get; set; }
        public virtual ICollection<TbThenAction> TbThenActions { get; set; }
    }
}
