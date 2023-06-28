using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechTalentHub.API.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "517b17f9-1a97-4543-b872-67fc80c04aa3", null, "Administrator", "ADMINISTRATOR" },
                    { "9556f0cd-6437-4780-8790-c85374d058da", null, "User", "USER" },
                    { "e0617316-d184-4c53-9105-9ccb1f877955", null, "Corporate", "CORPORATE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "517b17f9-1a97-4543-b872-67fc80c04aa3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9556f0cd-6437-4780-8790-c85374d058da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0617316-d184-4c53-9105-9ccb1f877955");
        }
    }
}
