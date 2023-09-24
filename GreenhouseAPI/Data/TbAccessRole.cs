using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbAccessRole
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public int IdPremission { get; set; }
        public bool AccessRoot { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbPremissionRole IdPremissionNavigation { get; set; } = null!;
        public virtual TbRole IdRoleNavigation { get; set; } = null!;
    }
}
