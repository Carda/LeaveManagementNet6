using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                column: "ConcurrencyStamp",
                value: "d5ea3c35-a0a3-4926-86af-6d830015828a");

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4ba98bba-3669-4938-9493-dff481f82624", true, "CAGDAS.ARDA1@LIVE.COM", "AQAAAAEAACcQAAAAEGN+TFvCQPIpL/Esf0AKJIB4qrlIE3sgpyNChkajKiLPJ0eqEJaX3j8uC8Br/GI0DA==", "5f3047a4-c48d-4306-95ce-bc18502d5a6e", "cagdas.arda1@live.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c2b65b6-2790-4d30-a841-369bb709c16a", true, "CAGDAS.ARDA@LIVE.COM", "AQAAAAEAACcQAAAAEPndmNwLrT1vT0iZFBIuaDLmaqZwzZnjeFZLm2S3e1OSnZP/Yeu+z9X712R6ReLmlg==", "07536e90-9816-48c1-a1cd-b2840dba49f9", "cagdas.arda@live.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                column: "ConcurrencyStamp",
                value: "bb4701f3-b42c-43a6-bac1-dcc81a27878d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2",
                column: "ConcurrencyStamp",
                value: "9d6153dd-2938-4543-9ef4-52bbd5572d84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-8bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1ef3c082-7415-4f08-89b8-fbf360f61a14", false, null, "AQAAAAEAACcQAAAAEMwVVxFjhTqW3Rwhi+iBt7vmum1uSsq2iXd3hYGzsaarAIEOb3m4CdkB2gnOxBg6Ww==", "faee7b84-180e-4fed-8da9-2a46d3dbcbda", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-9bdb-650c04b2d9d2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9ec79c0c-061e-41b2-9827-ddace6c13b41", false, null, "AQAAAAEAACcQAAAAECkJfI6Cz3uGnG9ua752wQ5nyjanCwzaJQB8FNovwR9gaa9XbkGNd5ooBEM69bG+HQ==", "fbd5fecc-1135-4a5e-8106-ab9cc8e9f14d", null });
        }
    }
}
