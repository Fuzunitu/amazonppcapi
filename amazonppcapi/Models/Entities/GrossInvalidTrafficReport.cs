namespace amazonppcapi.Models.Entities
{
    public class GrossInvalidTrafficReport
    {
        public int? Id { get; set; }
        public DateTime? GitrDate { get; set; }
        public string? GitrCampaignName { get; set; }
        public string? GitrStatus { get; set; }
        public int? GitrGrossImpressions { get; set; }
        public int? GitrImpressions { get; set; }
        public int? GitrInvalidImpressions { get; set; }
        public decimal? GitrInvalidImpressionRate { get; set; }
        public int? GitrGrossClicks { get; set; }
        public int? GitrClicks { get; set; }
        public int? GitrInvalidClicks { get; set; }
        public decimal? GitrInvalidClickRate { get; set; }

    }
}
