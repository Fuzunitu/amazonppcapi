namespace amazonppcapi.Models.Entities
{
    public class SearchTermReport
    {
        public int? Id { get; set; }
        public DateTimeOffset? StrDate { get; set; }
        public string? StrPortfolioName { get; set; }
        public string? StrCurrency { get; set; }
        public string? StrCampaignName { get; set; }
        public string? StrAdGroupName { get; set; }
        public string? StrTargeting { get; set; }
        public string? StrMatchType { get; set; }
        public string? StrCustomerSearchTerm { get; set; }
        public int? StrImpressions { get; set; }
        public int? StrClicks { get; set; }
        public decimal? StrClickThruRateCtr { get; set; }
        public decimal? StrCostPerClickCpc { get; set; }
        public decimal? StrSpend { get; set; }
        public decimal? Str7DayTotalSales { get; set; }
        public decimal? StrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? StrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public int? Str7DayTotalOrders { get; set; }
        public int? Str7DayTotalUnits { get; set; }
        public decimal? Str7DayConversionRate { get; set; }
        public int? Str7DayAdvertisedSkuUnits { get; set; }
        public int? Str7DayOtherSkuUnits { get; set; }
        public decimal? Str7DayAdvertisedSkuSales { get; set; }
        public decimal? Str7DayOtherSkuSales { get; set; }
    }
}
