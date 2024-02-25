using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stockExchange.API.Migrations
{
    public partial class SeedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1f56626-d5e6-4361-b758-10d21c2b4e07", "db9ac497-1e64-4757-9891-7cad9b7b03b8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f56626-d5e6-4361-b758-10d21c2b4e07");
        }
    }
}
