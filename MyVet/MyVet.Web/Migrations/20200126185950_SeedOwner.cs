using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.Web.Migrations
{
    public partial class SeedOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "CellPhone", "Document", "FirstName", "FixedPhone", "LastName" },
                values: new object[] { 1, "Calle Luna Calle Sol", "310 322 3221", "8989898", "Juan", "234 3232", "Zuluaga" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "CellPhone", "Document", "FirstName", "FixedPhone", "LastName" },
                values: new object[] { 2, "Calle 77 #22 21", "300 322 3221", "7655544", "Jose", "343 3226", "Cardona" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "CellPhone", "Document", "FirstName", "FixedPhone", "LastName" },
                values: new object[] { 3, "Carrera 56 #22 21", "350 322 3221", "6565555", "Maria", "450 4332", "López" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
