﻿namespace amazonppcapi.Models.Entities
{
    public class PerformanceOverTimeReport
    {
        public int? Id { get; set; }
        public DateTimeOffset? PotrDate { get; set; }
        public int? PotrClicks { get; set; }
        public decimal? PotrCostPerClickCpc { get; set; }
        public decimal? PotrSpend { get; set; }
    }
}
