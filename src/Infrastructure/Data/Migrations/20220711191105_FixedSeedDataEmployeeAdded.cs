using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class FixedSeedDataEmployeeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Darkstores_DarkstoreId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DarkstoreId",
                table: "Employees",
                newName: "IX_Employees_DarkstoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccountNumber", "DarkstoreId", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, "00000001", 1, "Homer", "Simpson", "courier" },
                    { 2, "00000002", 1, "Marge", "Simpson", "picker" },
                    { 3, "00000003", 1, "Bart", "Simpson", "courier" },
                    { 4, "00000004", 2, "Philip", "Fry", "courier" },
                    { 5, "00000005", 2, "Farnsworth", "Professor", "courier" },
                    { 6, "00000006", 2, "Leela", "Turanga", "picker" },
                    { 7, "00000007", 3, "Stan", "Smith", "picker" },
                    { 8, "00000008", 3, "Steve", "Smith", "courier" },
                    { 9, "00000003", 3, "Roger", "Smith", "courier" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Darkstores_DarkstoreId",
                table: "Employees",
                column: "DarkstoreId",
                principalTable: "Darkstores",
                principalColumn: "DarkstoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Darkstores_DarkstoreId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DarkstoreId",
                table: "Employee",
                newName: "IX_Employee_DarkstoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Darkstores_DarkstoreId",
                table: "Employee",
                column: "DarkstoreId",
                principalTable: "Darkstores",
                principalColumn: "DarkstoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
