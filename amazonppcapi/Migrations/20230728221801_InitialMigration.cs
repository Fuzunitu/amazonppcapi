using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace amazonppcapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisedProductsReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AprDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AprPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprAdGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprAdvertisedSku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprAdvertisedAsin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AprImpressions = table.Column<int>(type: "int", nullable: true),
                    AprClicks = table.Column<int>(type: "int", nullable: true),
                    AprCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AprCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AprSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Apr7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AprTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AprTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Apr7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    Apr7DayTotalUnits = table.Column<int>(type: "int", nullable: true),
                    Apr7DayConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Apr7DayAdvertisedSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Apr7DayOtherSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Apr7DayAdvertisedSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Apr7DayOtherSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisedProductsReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrCampaignType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrRecommendedBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrAverageTimeInBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrTargetingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrBiddingStrategy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrImpressions = table.Column<int>(type: "int", nullable: true),
                    BrLastYearImpressions = table.Column<int>(type: "int", nullable: true),
                    BrEstimatedMissedImpressionsRangeMin = table.Column<int>(type: "int", nullable: true),
                    BrEstimatedMissedImpressionsRangeMax = table.Column<int>(type: "int", nullable: true),
                    BrClicks = table.Column<int>(type: "int", nullable: true),
                    BrLastYearClicks = table.Column<int>(type: "int", nullable: true),
                    BrEstimatedMissedClicksRangeMin = table.Column<int>(type: "int", nullable: true),
                    BrEstimatedMissedClicksRangeMax = table.Column<int>(type: "int", nullable: true),
                    BrCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrLastYearSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrLastYearCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Br7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    BrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Br7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrEstimatedMissedSalesRangeMin = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrEstimatedMissedSalesRangeMax = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CrStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CrEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CrPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrCampaignType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrTargetingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrBiddingStrategy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrImpressions = table.Column<int>(type: "int", nullable: true),
                    CrLastYearImpressions = table.Column<int>(type: "int", nullable: true),
                    CrClicks = table.Column<int>(type: "int", nullable: true),
                    CrLastYearClicks = table.Column<int>(type: "int", nullable: true),
                    CrCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrLastYearSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrLastYearCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cr7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    CrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cr7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrossInvalidTrafficReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GitrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitrStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitrGrossImpressions = table.Column<int>(type: "int", nullable: true),
                    GitrImpressions = table.Column<int>(type: "int", nullable: true),
                    GitrInvalidImpressions = table.Column<int>(type: "int", nullable: true),
                    GitrInvalidImpressionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GitrGrossClicks = table.Column<int>(type: "int", nullable: true),
                    GitrClicks = table.Column<int>(type: "int", nullable: true),
                    GitrInvalidClicks = table.Column<int>(type: "int", nullable: true),
                    GitrInvalidClickRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossInvalidTrafficReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceOverTimeReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PotrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PotrClicks = table.Column<int>(type: "int", nullable: true),
                    PotrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PotrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceOverTimeReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedProductReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PprDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PprPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprAdGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprAdvertisedSku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprAdvertisedAsin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprTargeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprMatchType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PprPurchasedAsin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ppr7DayOtherSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Ppr7DayOtherSkuOrders = table.Column<int>(type: "int", nullable: true),
                    Ppr7DayOtherSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedProductReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchTermImpressionShareReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsrCustomerSearchTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrSearchTermImpressionRank = table.Column<int>(type: "int", nullable: true),
                    IsrSearchTermImpressionShare = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsrTargeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrMatchType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrAdGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsrClicks = table.Column<int>(type: "int", nullable: true),
                    IsrImpressions = table.Column<int>(type: "int", nullable: true),
                    IsrClickThruRateCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Isr7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    Isr7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Isr7DayConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTermImpressionShareReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchTermsReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StrPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrAdGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrTargeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMatchType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrCustomerSearchTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrImpressions = table.Column<int>(type: "int", nullable: true),
                    StrClicks = table.Column<int>(type: "int", nullable: true),
                    StrClickThruRateCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Str7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Str7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    Str7DayTotalUnits = table.Column<int>(type: "int", nullable: true),
                    Str7DayConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Str7DayAdvertisedSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Str7DayOtherSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Str7DayAdvertisedSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Str7DayOtherSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTermsReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetingReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrPortfolioName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrCampaignName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrAdGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrTargeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrMatchType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrImpressions = table.Column<int>(type: "int", nullable: true),
                    TrClicks = table.Column<int>(type: "int", nullable: true),
                    TrClickThruRateCtr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrCostPerClickCpc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrSpend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tr7DayTotalSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tr7DayTotalOrders = table.Column<int>(type: "int", nullable: true),
                    Tr7DayTotalUnits = table.Column<int>(type: "int", nullable: true),
                    Tr7DayConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tr7DayAdvertisedSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Tr7DayOtherSkuUnits = table.Column<int>(type: "int", nullable: true),
                    Tr7DayAdvertisedSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tr7DayOtherSkuSales = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetingReport", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisedProductsReports");

            migrationBuilder.DropTable(
                name: "BudgetReport");

            migrationBuilder.DropTable(
                name: "CampaignReport");

            migrationBuilder.DropTable(
                name: "GrossInvalidTrafficReport");

            migrationBuilder.DropTable(
                name: "PerformanceOverTimeReport");

            migrationBuilder.DropTable(
                name: "PurchasedProductReport");

            migrationBuilder.DropTable(
                name: "SearchTermImpressionShareReport");

            migrationBuilder.DropTable(
                name: "SearchTermsReport");

            migrationBuilder.DropTable(
                name: "TargetingReport");
        }
    }
}
