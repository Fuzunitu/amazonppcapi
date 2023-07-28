namespace amazonppcapi.Models.Entities
{
    public class AdvertisedProductReport
    {
        public int Id { get; set; } // Primary Key
        public DateTime AprDate { get; set; }
        public string? AprPortfolioName { get; set; }
        public string? AprCurrency { get; set; }
        public string? AprCampaignName { get; set; }
        public string? AprAdGroupName { get; set; }
        public string? AprAdvertisedSku { get; set; }
        public string? AprAdvertisedAsin { get; set; }
        public int? AprImpressions { get; set; }
        public int? AprClicks { get; set; }
        public decimal? AprCtr { get; set; }
        public decimal? AprCpc { get; set; }
        public decimal? AprSpend { get; set; }
        public decimal? Apr7DayTotalSales { get; set; }
        public decimal? AprTotalAdvertisingCostOfSalesAcos { get; set; }
        public decimal? AprTotalReturnOnAdvertisingSpendRoas { get; set; }
        public int? Apr7DayTotalOrders { get; set; }
        public int? Apr7DayTotalUnits { get; set; }
        public decimal? Apr7DayConversionRate { get; set; }
        public int? Apr7DayAdvertisedSkuUnits { get; set; }
        public int? Apr7DayOtherSkuUnits { get; set; }
        public decimal? Apr7DayAdvertisedSkuSales { get; set; }
        public decimal? Apr7DayOtherSkuSales { get; set; }
    }
}
