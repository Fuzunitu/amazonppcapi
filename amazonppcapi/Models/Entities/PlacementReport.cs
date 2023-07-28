namespace amazonppcapi.Models.Entities
{
    public class PlacementReport
    {
        public int? Id { get; set; }
        public DateTime? PrDate { get; set; }
        public string? PrPortfolioName { get; set; }
        public string? PrCurrency { get; set; }
        public string? PrCampaignName { get; set; }
        public string? PrBiddingStrategy { get; set; }
        public string? PrPlacement { get; set; }
        public int? PrImpressions { get; set; }
        public int? PrClicks { get; set; }
        public decimal? PrCostPerClickCpc { get; set; }
        public decimal? PrSpend { get; set; }
        public decimal? Pr7DayTotalSales { get; set; }
        public decimal? PrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? PrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public int? Pr7DayTotalOrders { get; set; }
        public int? Pr7DayTotalUnits { get; set; }

    }
}
