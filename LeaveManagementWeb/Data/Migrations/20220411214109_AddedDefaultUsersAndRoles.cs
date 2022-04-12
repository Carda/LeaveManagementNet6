using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aedd2960-fefc-33d3-9bdb-650c04b2d9d2", "bb4701f3-b42c-43a6-bac1-dcc81a27878d", "Administrator", "ADMINISTRATOR" },
                    { "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2", "9d6153dd-2938-4543-9ef4-52bbd5572d84", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aedd2960-fefc-45d3-8bdb-650c04b2d9d2", 0, "1ef3c082-7415-4f08-89b8-fbf360f61a14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cagdas.arda1@live.com", false, "User", "Admin", false, null, "CAGDAS.ARDA1@LIVE.COM", null, "AQAAAAEAACcQAAAAEMwVVxFjhTqW3Rwhi+iBt7vmum1uSsq2iXd3hYGzsaarAIEOb3m4CdkB2gnOxBg6Ww==", null, false, "faee7b84-180e-4fed-8da9-2a46d3dbcbda", null, false, null },
                    { "aedd2960-fefc-45d3-9bdb-650c04b2d9d2", 0, "9ec79c0c-061e-41b2-9827-ddace6c13b41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cagdas.arda@live.com", false, "System", "Admin", false, null, "CAGDAS.ARDA@LIVE.COM", null, "AQAAAAEAACcQAAAAECkJfI6Cz3uGnG9ua752wQ5nyjanCwzaJQB8FNovwR9gaa9XbkGNd5ooBEM69bG+HQ==", null, false, "fbd5fecc-1135-4a5e-8106-ab9cc8e9f14d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2", "aedd2960-fefc-45d3-8bdb-650c04b2d9d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aedd2960-fefc-33d3-9bdb-650c04b2d9d2", "aedd2960-fefc-45d3-9bdb-650c04b2d9d2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2", "aedd2960-fefc-45d3-8bdb-650c04b2d9d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aedd2960-fefc-33d3-9bdb-650c04b2d9d2", "aedd2960-fefc-45d3-9bdb-650c04b2d9d2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-33d3-9bdb-650c04b2d9d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-8bdb-650c04b2d9d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aedd2960-fefc-45d3-9bdb-650c04b2d9d2");
        }
    }
}
