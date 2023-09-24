using System;
using System.Collections.Generic;

namespace GreenhouseAPI.Data
{
    public partial class TbTempFunction
    {
        public int Id { get; set; }
        public int? IdFunction { get; set; }
        public int? Step { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
