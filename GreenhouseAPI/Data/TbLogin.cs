using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbLogin
    {
        public int LoginId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public DateTime CraeteAt { get; set; }
    }
}
