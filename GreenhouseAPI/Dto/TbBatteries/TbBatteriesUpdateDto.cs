﻿namespace GreenhouseAPI.Dto.TbBatteries
{
    public class TbBatteriesUpdateDto
    {
        public int Id { get; set; }
        public string? FaName { get; set; }
        public string? EnName { get; set; }
        public double Voltage { get; set; }
        public bool? IsActive { get; set; }
    }
}
