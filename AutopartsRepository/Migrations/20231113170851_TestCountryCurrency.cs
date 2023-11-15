using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class TestCountryCurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumericCurrencyCode = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumericCountryCode = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ISOAlpha2 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ISOAlpha3 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CountryNameCZ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryNameENG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "13.11.2023", "CZK", "Česká koruna", true, 203, null },
                    { 2, "13.11.2023", "EUR", "Euro", true, 978, null },
                    { 3, "13.11.2023", "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", "13.11.2023", 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", "13.11.2023", 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", "13.11.2023", 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", "13.11.2023", 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", "13.11.2023", 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
