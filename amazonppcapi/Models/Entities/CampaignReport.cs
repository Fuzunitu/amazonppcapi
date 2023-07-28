namespace amazonppcapi.Models.Entities
{
    public class CampaignReport
    {
        public int? Id { get; set; }
        public DateTime? CrDate { get; set; }
        public DateTime? CrStartDate { get; set; }
        public DateTime? CrEndDate { get; set; }
        public string? CrPortfolioName { get; set; }
        public string? CrCampaignType { get; set; }
        public string? CrCampaignName { get; set; }
        public string? CrStatus { get; set; }
        public string? CrCurrency { get; set; }
        public decimal? CrBudget { get; set; }
        public string? CrTargetingType { get; set; }
        public string? CrBiddingStrategy { get; set; }
        public int? CrImpressions { get; set; }
        public int? CrLastYearImpressions { get; set; }
        public int? CrClicks { get; set; }
        public int? CrLastYearClicks { get; set; }
        public decimal? CrCtr { get; set; }
        public decimal? CrSpend { get; set; }
        public decimal? CrLastYearSpend { get; set; }
        public decimal? CrCostPerClickCpc { get; set; }
        public decimal? CrLastYearCostPerClickCpc { get; set; }
        public int? Cr7DayTotalOrders { get; set; }
        public decimal? CrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? CrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public decimal? Cr7DayTotalSales { get; set; }

    }
}
