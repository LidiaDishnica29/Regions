using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegionsTask.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("324c6b2c-cdec-4c8d-bc21-4fe0cdad00c8"), "001", "Country 1" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("ff6cbbb8-87c6-4d33-a909-bf6781ad054a"), "0011", "Region 2" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { new Guid("8c8648e6-b2e1-4b66-9c57-9d94ad959b0e"), "0012", "Region 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("324c6b2c-cdec-4c8d-bc21-4fe0cdad00c8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8c8648e6-b2e1-4b66-9c57-9d94ad959b0e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ff6cbbb8-87c6-4d33-a909-bf6781ad054a"));
        }
    }
}
