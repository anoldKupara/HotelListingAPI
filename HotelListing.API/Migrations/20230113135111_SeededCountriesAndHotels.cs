using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededCountriesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Jamaica", "JM" },
                    { 2, "Bahamas", "BS" },
                    { 3, "Cayman Islands", "CI" },
                    { 4, "Cuba", "CU" },
                    { 5, "Dominican Republic", "DR" },
                    { 6, "Haiti", "HT" },
                    { 7, "Trinidad and Tobago", "TT" },
                    { 8, "United States", "US" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Nassau, New Providence Island", 2, "Sandals Royal Bahamian", 4.5 },
                    { 2, "Montego Bay, Jamaica", 1, "Sandals Royal Caribbean", 4.5 },
                    { 3, "Montego Bay, Jamaica", 1, "Sandals Montego Bay", 4.5 },
                    { 4, "Negril, Jamaica", 1, "Sandals Negril Beach Resort & Spa", 4.5 },
                    { 5, "Whitehouse, Jamaica", 1, "Sandals South Coast", 4.5 },
                    { 6, "Ocho Rios, Jamaica", 1, "Sandals Ochi Beach Resort", 4.5 },
                    { 7, "Castries, St. Lucia", 1, "Sandals Grande St. Lucian Spa & Beach Resort", 4.5 },
                    { 8, "St. George's, Grenada", 1, "Sandals LaSource Grenada Resort & Spa", 4.5 },
                    { 9, "Great Exuma, Bahamas", 2, "Sandals Emerald Bay Golf, Tennis & Spa Resort", 4.5 },
                    { 10, "Montego Bay, Jamaica", 1, "Sandals Royal Caribbean", 4.5 },
                    { 11, "St. John's, Antigua", 1, "Sandals Grande Antigua Resort & Spa", 4.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
