using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class addingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b22de18f-90d5-4355-a4ea-407aa0f57d6f", "ADMİNİSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2",
                column: "ConcurrencyStamp",
                value: "52e603e9-c61a-42f9-a5ec-30e9849f0765");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-8bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59794b5d-e4ab-4ae2-94e6-53eb6a72434e", "AQAAAAEAACcQAAAAEHo1ZcsrgN1PU1ly75FYDotB8Q8V/yf5ZNnHTEgHF0DEjrV4H/ypxMBXsmNUUuQ8Yw==", "855848c4-d85d-4173-84fd-66d46d62d039" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47bfae2d-1a91-415a-b557-4ca3966be5c5", "AQAAAAEAACcQAAAAEAK627d8eN3LGCeDpcz1LpTaeuCwHABoEGgreiDQMn1brL0eC2IlF+QwSwFmkZ9seA==", "ee443ca2-8649-4749-9da1-9ebe15eaf48c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "d5ea3c35-a0a3-4926-86af-6d830015828a", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2",
                column: "ConcurrencyStamp",
                value: "22d39ab6-b9ad-4f42-8fe2-7a5b62318880");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-8bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ba98bba-3669-4938-9493-dff481f82624", "AQAAAAEAACcQAAAAEGN+TFvCQPIpL/Esf0AKJIB4qrlIE3sgpyNChkajKiLPJ0eqEJaX3j8uC8Br/GI0DA==", "5f3047a4-c48d-4306-95ce-bc18502d5a6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c2b65b6-2790-4d30-a841-369bb709c16a", "AQAAAAEAACcQAAAAEPndmNwLrT1vT0iZFBIuaDLmaqZwzZnjeFZLm2S3e1OSnZP/Yeu+z9X712R6ReLmlg==", "07536e90-9816-48c1-a1cd-b2840dba49f9" });
        }
    }
}
