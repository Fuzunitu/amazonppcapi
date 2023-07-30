namespace amazonppcapi.Models.Entities
{
    public class PurchasedProductReport
    {
        public int? Id { get; set; }
        public DateTimeOffset? PprDate { get; set; }
        public string? PprPortfolioName { get; set; }
        public string? PprCurrency { get; set; }
        public string? PprCampaignName { get; set; }
        public string? PprAdGroupName { get; set; }
        public string? PprAdvertisedSku { get; set; }
        public string? PprAdvertisedAsin { get; set; }
        public string? PprTargeting { get; set; }
        public string? PprMatchType { get; set; }
        public string? PprPurchasedAsin { get; set; }
        public int? Ppr7DayOtherSkuUnits { get; set; }
        public int? Ppr7DayOtherSkuOrders { get; set; }
        public decimal? Ppr7DayOtherSkuSales { get; set; }

    }
}
