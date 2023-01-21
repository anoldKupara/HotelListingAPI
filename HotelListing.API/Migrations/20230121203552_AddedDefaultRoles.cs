using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14971e31-feb2-426a-9f93-1381e755563b", "27acfe9a-22a0-4bd3-b144-b805f8866400", "Adminstrator", "ADMINSTRATOR" },
                    { "65e64429-f175-4ce2-ba1f-db4948610ed3", "ffcb4566-43ca-4bf5-8d7a-1b3448f45149", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14971e31-feb2-426a-9f93-1381e755563b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65e64429-f175-4ce2-ba1f-db4948610ed3");
        }
    }
}
