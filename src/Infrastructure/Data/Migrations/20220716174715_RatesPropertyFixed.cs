using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class RatesPropertyFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Rates");

            migrationBuilder.AddColumn<decimal>(
                name: "RatePerHour",
                table: "Rates",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatePerHour",
                table: "Rates");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Rates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
