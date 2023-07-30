using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace amazonppcapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertisedProductsReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AprDate = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false),
                    AprPortfolioName = table.Column<string>(type: "text", nullable: true),
                    AprCurrency = table.Column<string>(type: "text", nullable: true),
                    AprCampaignName = table.Column<string>(type: "text", nullable: true),
                    AprAdGroupName = table.Column<string>(type: "text", nullable: true),
                    AprAdvertisedSku = table.Column<string>(type: "text", nullable: true),
                    AprAdvertisedAsin = table.Column<string>(type: "text", nullable: true),
                    AprImpressions = table.Column<int>(type: "integer", nullable: true),
                    AprClicks = table.Column<int>(type: "integer", nullable: true),
                    AprCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    AprCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    AprSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    Apr7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    AprTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    AprTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Apr7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    Apr7DayTotalUnits = table.Column<int>(type: "integer", nullable: true),
                    Apr7DayConversionRate = table.Column<decimal>(type: "numeric", nullable: true),
                    Apr7DayAdvertisedSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Apr7DayOtherSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Apr7DayAdvertisedSkuSales = table.Column<decimal>(type: "numeric", nullable: true),
                    Apr7DayOtherSkuSales = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisedProductsReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    BrStartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    BrEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    BrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    BrCampaignType = table.Column<string>(type: "text", nullable: true),
                    BrCampaignName = table.Column<string>(type: "text", nullable: true),
                    BrStatus = table.Column<string>(type: "text", nullable: true),
                    BrCurrency = table.Column<string>(type: "text", nullable: true),
                    BrBudget = table.Column<decimal>(type: "numeric", nullable: true),
                    BrRecommendedBudget = table.Column<decimal>(type: "numeric", nullable: true),
                    BrAverageTimeInBudget = table.Column<decimal>(type: "numeric", nullable: true),
                    BrTargetingType = table.Column<string>(type: "text", nullable: true),
                    BrBiddingStrategy = table.Column<string>(type: "text", nullable: true),
                    BrImpressions = table.Column<int>(type: "integer", nullable: true),
                    BrLastYearImpressions = table.Column<int>(type: "integer", nullable: true),
                    BrEstimatedMissedImpressionsRangeMin = table.Column<int>(type: "integer", nullable: true),
                    BrEstimatedMissedImpressionsRangeMax = table.Column<int>(type: "integer", nullable: true),
                    BrClicks = table.Column<int>(type: "integer", nullable: true),
                    BrLastYearClicks = table.Column<int>(type: "integer", nullable: true),
                    BrEstimatedMissedClicksRangeMin = table.Column<int>(type: "integer", nullable: true),
                    BrEstimatedMissedClicksRangeMax = table.Column<int>(type: "integer", nullable: true),
                    BrCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    BrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    BrLastYearSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    BrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    BrLastYearCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    Br7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    BrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    BrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Br7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    BrEstimatedMissedSalesRangeMin = table.Column<decimal>(type: "numeric", nullable: true),
                    BrEstimatedMissedSalesRangeMax = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CrStartDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CrEndDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    CrCampaignType = table.Column<string>(type: "text", nullable: true),
                    CrCampaignName = table.Column<string>(type: "text", nullable: true),
                    CrStatus = table.Column<string>(type: "text", nullable: true),
                    CrCurrency = table.Column<string>(type: "text", nullable: true),
                    CrBudget = table.Column<decimal>(type: "numeric", nullable: true),
                    CrTargetingType = table.Column<string>(type: "text", nullable: true),
                    CrBiddingStrategy = table.Column<string>(type: "text", nullable: true),
                    CrImpressions = table.Column<int>(type: "integer", nullable: true),
                    CrLastYearImpressions = table.Column<int>(type: "integer", nullable: true),
                    CrClicks = table.Column<int>(type: "integer", nullable: true),
                    CrLastYearClicks = table.Column<int>(type: "integer", nullable: true),
                    CrCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    CrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    CrLastYearSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    CrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    CrLastYearCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    Cr7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    CrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    CrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Cr7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrossInvalidTrafficReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GitrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    GitrCampaignName = table.Column<string>(type: "text", nullable: true),
                    GitrStatus = table.Column<string>(type: "text", nullable: true),
                    GitrGrossImpressions = table.Column<int>(type: "integer", nullable: true),
                    GitrImpressions = table.Column<int>(type: "integer", nullable: true),
                    GitrInvalidImpressions = table.Column<int>(type: "integer", nullable: true),
                    GitrInvalidImpressionRate = table.Column<decimal>(type: "numeric", nullable: true),
                    GitrGrossClicks = table.Column<int>(type: "integer", nullable: true),
                    GitrClicks = table.Column<int>(type: "integer", nullable: true),
                    GitrInvalidClicks = table.Column<int>(type: "integer", nullable: true),
                    GitrInvalidClickRate = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossInvalidTrafficReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceOverTimeReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PotrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    PotrClicks = table.Column<int>(type: "integer", nullable: true),
                    PotrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    PotrSpend = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceOverTimeReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedProductReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PprDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    PprPortfolioName = table.Column<string>(type: "text", nullable: true),
                    PprCurrency = table.Column<string>(type: "text", nullable: true),
                    PprCampaignName = table.Column<string>(type: "text", nullable: true),
                    PprAdGroupName = table.Column<string>(type: "text", nullable: true),
                    PprAdvertisedSku = table.Column<string>(type: "text", nullable: true),
                    PprAdvertisedAsin = table.Column<string>(type: "text", nullable: true),
                    PprTargeting = table.Column<string>(type: "text", nullable: true),
                    PprMatchType = table.Column<string>(type: "text", nullable: true),
                    PprPurchasedAsin = table.Column<string>(type: "text", nullable: true),
                    Ppr7DayOtherSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Ppr7DayOtherSkuOrders = table.Column<int>(type: "integer", nullable: true),
                    Ppr7DayOtherSkuSales = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedProductReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchTermImpressionShareReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsrCustomerSearchTerm = table.Column<string>(type: "text", nullable: true),
                    IsrSearchTermImpressionRank = table.Column<int>(type: "integer", nullable: true),
                    IsrSearchTermImpressionShare = table.Column<decimal>(type: "numeric", nullable: true),
                    IsrTargeting = table.Column<string>(type: "text", nullable: true),
                    IsrMatchType = table.Column<string>(type: "text", nullable: true),
                    IsrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    IsrCampaignName = table.Column<string>(type: "text", nullable: true),
                    IsrAdGroupName = table.Column<string>(type: "text", nullable: true),
                    IsrCurrency = table.Column<string>(type: "text", nullable: true),
                    IsrClicks = table.Column<int>(type: "integer", nullable: true),
                    IsrImpressions = table.Column<int>(type: "integer", nullable: true),
                    IsrClickThruRateCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    IsrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    IsrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    Isr7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    Isr7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    IsrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    IsrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Isr7DayConversionRate = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTermImpressionShareReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchTermsReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    StrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    StrCurrency = table.Column<string>(type: "text", nullable: true),
                    StrCampaignName = table.Column<string>(type: "text", nullable: true),
                    StrAdGroupName = table.Column<string>(type: "text", nullable: true),
                    StrTargeting = table.Column<string>(type: "text", nullable: true),
                    StrMatchType = table.Column<string>(type: "text", nullable: true),
                    StrCustomerSearchTerm = table.Column<string>(type: "text", nullable: true),
                    StrImpressions = table.Column<int>(type: "integer", nullable: true),
                    StrClicks = table.Column<int>(type: "integer", nullable: true),
                    StrClickThruRateCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    StrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    StrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    Str7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    StrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    StrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Str7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    Str7DayTotalUnits = table.Column<int>(type: "integer", nullable: true),
                    Str7DayConversionRate = table.Column<decimal>(type: "numeric", nullable: true),
                    Str7DayAdvertisedSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Str7DayOtherSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Str7DayAdvertisedSkuSales = table.Column<decimal>(type: "numeric", nullable: true),
                    Str7DayOtherSkuSales = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTermsReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetingReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    TrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    TrCurrency = table.Column<string>(type: "text", nullable: true),
                    TrCampaignName = table.Column<string>(type: "text", nullable: true),
                    TrAdGroupName = table.Column<string>(type: "text", nullable: true),
                    TrTargeting = table.Column<string>(type: "text", nullable: true),
                    TrMatchType = table.Column<string>(type: "text", nullable: true),
                    TrImpressions = table.Column<int>(type: "integer", nullable: true),
                    TrClicks = table.Column<int>(type: "integer", nullable: true),
                    TrClickThruRateCtr = table.Column<decimal>(type: "numeric", nullable: true),
                    TrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    TrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    TrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    TrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Tr7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    Tr7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    Tr7DayTotalUnits = table.Column<int>(type: "integer", nullable: true),
                    Tr7DayConversionRate = table.Column<decimal>(type: "numeric", nullable: true),
                    Tr7DayAdvertisedSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Tr7DayOtherSkuUnits = table.Column<int>(type: "integer", nullable: true),
                    Tr7DayAdvertisedSkuSales = table.Column<decimal>(type: "numeric", nullable: true),
                    Tr7DayOtherSkuSales = table.Column<decimal>(type: "numeric", nullable: true)
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
