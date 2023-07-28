namespace amazonppcapi.Models.Entities
{
    public class BudgetReport
    {
        public int Id { get; set; }
        public DateTime? BrDate { get; set; }
        public DateTime? BrStartDate { get; set; }
        public DateTime? BrEndDate { get; set; }
        public string? BrPortfolioName { get; set; }
        public string? BrCampaignType { get; set; }
        public string? BrCampaignName { get; set; }
        public string? BrStatus { get; set; }
        public string? BrCurrency { get; set; }
        public decimal? BrBudget { get; set; }
        public decimal? BrRecommendedBudget { get; set; }
        public decimal? BrAverageTimeInBudget { get; set; }
        public string? BrTargetingType { get; set; }
        public string? BrBiddingStrategy { get; set; }
        public int? BrImpressions { get; set; }
        public int? BrLastYearImpressions { get; set; }
        public int? BrEstimatedMissedImpressionsRangeMin { get; set; }
        public int? BrEstimatedMissedImpressionsRangeMax { get; set; }
        public int? BrClicks { get; set; }
        public int? BrLastYearClicks { get; set; }
        public int? BrEstimatedMissedClicksRangeMin { get; set; }
        public int? BrEstimatedMissedClicksRangeMax { get; set; }
        public decimal? BrCtr { get; set; }
        public decimal? BrSpend { get; set; }
        public decimal? BrLastYearSpend { get; set; }
        public decimal? BrCostPerClickCpc { get; set; }
        public decimal? BrLastYearCostPerClickCpc { get; set; }
        public int? Br7DayTotalOrders { get; set; }
        public decimal? BrTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? BrTotalReturnOnAdvertisingSpendRoas { get; set; }
        public decimal? Br7DayTotalSales { get; set; }
        public decimal? BrEstimatedMissedSalesRangeMin { get; set; }
        public decimal? BrEstimatedMissedSalesRangeMax { get; set; }
    }
}
