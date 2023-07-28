namespace amazonppcapi.Models.Entities
{
    public class TargetingReport
    {
        public int? Id { get; set; }
        public DateTime? TrDate { get; set; }
        public string? TrPortfolioName { get; set; }
        public string? TrCurrency { get; set; }
        public string? TrCampaignName { get; set; }
        public string? TrAdGroupName { get; set; }
        public string? TrTargeting { get; set; }
        public string? TrMatchType { get; set; }
        public int? TrImpressions { get; set; }
        public int? TrClicks { get; set; }
        public decimal? TrClickThruRateCtr { get; set; }
        public decimal? TrCostPerClickCpc { get; set; }
        public decimal? TrSpend { get; set; }
        public decimal? TrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? TrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public decimal? Tr7DayTotalSales { get; set; }
        public int? Tr7DayTotalOrders { get; set; }
        public int? Tr7DayTotalUnits { get; set; }
        public decimal? Tr7DayConversionRate { get; set; }
        public int? Tr7DayAdvertisedSkuUnits { get; set; }
        public int? Tr7DayOtherSkuUnits { get; set; }
        public decimal? Tr7DayAdvertisedSkuSales { get; set; }
        public decimal? Tr7DayOtherSkuSales { get; set; }

    }
}
