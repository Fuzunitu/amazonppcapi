using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace amazonppcapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlacementReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    PrPortfolioName = table.Column<string>(type: "text", nullable: true),
                    PrCurrency = table.Column<string>(type: "text", nullable: true),
                    PrCampaignName = table.Column<string>(type: "text", nullable: true),
                    PrBiddingStrategy = table.Column<string>(type: "text", nullable: true),
                    PrPlacements = table.Column<string>(type: "text", nullable: true),
                    PrImpressions = table.Column<int>(type: "integer", nullable: true),
                    PrClicks = table.Column<int>(type: "integer", nullable: true),
                    PrCostPerClickCpc = table.Column<decimal>(type: "numeric", nullable: true),
                    PrSpend = table.Column<decimal>(type: "numeric", nullable: true),
                    Pr7DayTotalSales = table.Column<decimal>(type: "numeric", nullable: true),
                    PrTotalAdvertisingCostOfSalesAcos = table.Column<decimal>(type: "numeric", nullable: true),
                    PrTotalReturnOnAdvertisingSpendRoas = table.Column<decimal>(type: "numeric", nullable: true),
                    Pr7DayTotalOrders = table.Column<int>(type: "integer", nullable: true),
                    Pr7DayTotalUnits = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacementReport", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlacementReport");
        }
    }
}
