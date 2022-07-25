using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class SeedDataRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "Name", "RatePerHour" },
                values: new object[,]
                {
                    { 1, "Picker", 10m },
                    { 2, "Courier standart", 8m },
                    { 3, "Courier in company car", 12m },
                    { 4, "Courier in his car", 9.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
