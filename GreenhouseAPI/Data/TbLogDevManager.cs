using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogDevManager
    {
        public int Id { get; set; }
        public string AreaName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime LogDate { get; set; }
    }
}
