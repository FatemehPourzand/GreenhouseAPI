using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbHelp
    {
        public int IdPage { get; set; }
        public string TittleH { get; set; } = null!;
        public string DescriptionH { get; set; } = null!;
        public int GroupId { get; set; }
        public string? IconH { get; set; }
        public bool IsActive { get; set; }
    }
}
