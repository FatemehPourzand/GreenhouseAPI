using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbDashboard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ItemName { get; set; } = null!;
        public string? ItemId { get; set; }
        public string? Root { get; set; }

        public virtual TbUser User { get; set; } = null!;
    }
}
