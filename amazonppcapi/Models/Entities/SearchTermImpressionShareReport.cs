namespace amazonppcapi.Models.Entities
{
    public class SearchTermImpressionShareReport
    {
        public int? Id { get; set; }
        public DateTime? IsrDate { get; set; }
        public string? IsrCustomerSearchTerm { get; set; }
        public int? IsrSearchTermImpressionRank { get; set; }
        public decimal? IsrSearchTermImpressionShare { get; set; }
        public string? IsrTargeting { get; set; }
        public string? IsrMatchType { get; set; }
        public string? IsrPortfolioName { get; set; }
        public string? IsrCampaignName { get; set; }
        public string? IsrAdGroupName { get; set; }
        public string? IsrCurrency { get; set; }
        public int? IsrClicks { get; set; }
        public int? IsrImpressions { get; set; }
        public decimal? IsrClickThruRateCtr { get; set; }
        public decimal? IsrSpend { get; set; }
        public decimal? IsrCostPerClickCpc { get; set; }
        public int? Isr7DayTotalOrders { get; set; }
        public decimal? Isr7DayTotalSales { get; set; }
        public decimal? IsrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? IsrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public decimal? Isr7DayConversionRate { get; set; }

    }
}
