using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class SeedDataDarkstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Darkstores",
                columns: new[] { "DarkstoreId", "Name" },
                values: new object[] { 1, "Brooklyn" });

            migrationBuilder.InsertData(
                table: "Darkstores",
                columns: new[] { "DarkstoreId", "Name" },
                values: new object[] { 2, "The Bronx" });

            migrationBuilder.InsertData(
                table: "Darkstores",
                columns: new[] { "DarkstoreId", "Name" },
                values: new object[] { 3, "Queens" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Darkstores",
                keyColumn: "DarkstoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Darkstores",
                keyColumn: "DarkstoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Darkstores",
                keyColumn: "DarkstoreId",
                keyValue: 3);
        }
    }
}
