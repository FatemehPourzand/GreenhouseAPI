using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLicence
    {
        public int IdLicence { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int IdArea { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual TbArea IdAreaNavigation { get; set; } = null!;
    }
}
