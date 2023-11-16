using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class StartModelBrandCountryCurrencyWarranty : Migration
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
                    CurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumericCountryCode = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ISOAlpha2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ISOAlpha3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryNameCZ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryNameENG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecDoc = table.Column<int>(type: "int", maxLength: 6, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GeneralInformation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CountryId", "CreateDate", "GeneralInformation", "IsActive", "LogoPath", "TecDoc", "Title", "UpdateDate", "WebSite" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7661), null, true, null, 2, "HELLA", null, null },
                    { 3, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7665), null, true, null, 3, "ATE", null, null },
                    { 4, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7669), null, true, null, 4, "MANN-FILTER", null, null },
                    { 5, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7672), null, true, null, 5, "PIERBURG", null, null },
                    { 6, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7686), null, true, null, 6, "LuK", null, null },
                    { 7, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7690), null, true, null, 7, "EBERSPÄCHER", null, null },
                    { 8, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7693), null, true, null, 9, "VICTOR REINZ", null, null },
                    { 9, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7696), null, true, null, 10, "ELRING", null, null },
                    { 10, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7699), null, true, null, 11, "BorgWarner (BERU)", null, null },
                    { 11, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7703), null, true, null, 13, "WALKER", null, null },
                    { 12, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7707), null, true, null, 15, "NGK", null, null },
                    { 13, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7710), null, true, null, 16, "BILSTEIN", null, null },
                    { 14, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7714), null, true, null, 18, "KONI", null, null },
                    { 15, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7717), null, true, null, 19, "SWF", null, null },
                    { 16, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7720), null, true, null, 21, "VALEO", null, null },
                    { 17, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7723), null, true, null, 23, "RUVILLE", null, null },
                    { 18, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7726), null, true, null, 24, "EXIDE", null, null },
                    { 19, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7730), null, true, null, 26, "VARTA", null, null },
                    { 20, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7733), null, true, null, 29, "ERNST", null, null },
                    { 21, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7736), null, true, null, 30, "BOSCH", null, null },
                    { 22, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7740), null, true, null, 31, "CONTINENTAL CTAM", null, null },
                    { 23, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7743), null, true, null, 32, "SACHS", null, null },
                    { 24, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7746), null, true, null, 33, "GATES", null, null },
                    { 25, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7749), null, true, null, 34, "KNECHT", null, null },
                    { 26, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7753), null, true, null, 35, "LEMFÖRDER", null, null },
                    { 27, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7756), null, true, null, 36, "VAN WEZEL", null, null },
                    { 28, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7759), null, true, null, 37, "MONROE", null, null },
                    { 29, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7763), null, true, null, 38, "PURFLUX", null, null },
                    { 30, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7766), null, true, null, 39, "TEXTAR", null, null },
                    { 31, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7769), null, true, null, 41, "BOSAL", null, null },
                    { 32, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7774), null, true, null, 42, "DAYCO", null, null },
                    { 33, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7777), null, true, null, 43, "CHAMPION", null, null },
                    { 34, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7780), null, true, null, 47, "BREMI", null, null },
                    { 35, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7783), null, true, null, 48, "JURID", null, null },
                    { 36, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7786), null, true, null, 50, "SKF", null, null },
                    { 37, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7790), null, true, null, 51, "WESTFALIA", null, null },
                    { 38, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7793), null, true, null, 54, "FTE", null, null },
                    { 39, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7796), null, true, null, 55, "HERTH+BUSS JAKOPARTS", null, null },
                    { 40, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7799), null, true, null, 56, "LÖBRO", null, null },
                    { 41, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7802), null, true, null, 57, "QUINTON HAZELL", null, null },
                    { 42, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7806), null, true, null, 61, "TYC", null, null },
                    { 43, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7809), null, true, null, 65, "BREMBO", null, null },
                    { 44, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7813), null, true, null, 66, "DENSO", null, null },
                    { 45, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7816), null, true, null, 67, "OSRAM", null, null },
                    { 46, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7819), null, true, null, 68, "ZF", null, null },
                    { 47, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7822), null, true, null, 72, "HERTH+BUSS ELPARTS", null, null },
                    { 48, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7825), null, true, null, 75, "PHILIPS", null, null },
                    { 49, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7828), null, true, null, 78, "KLOKKERHOLM", null, null },
                    { 50, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7831), null, true, null, 79, "BorgWarner (Wahler)", null, null },
                    { 51, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7835), null, true, null, 81, "HENGST FILTER", null, null },
                    { 52, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7839), null, true, null, 83, "CONTINENTAL/VDO", null, null },
                    { 53, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7842), null, true, null, 85, "KYB", null, null },
                    { 54, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7845), null, true, null, 86, "ZIMMERMANN", null, null },
                    { 55, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7848), null, true, null, 88, "GLASER", null, null },
                    { 56, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7852), null, true, null, 89, "DELPHI", null, null },
                    { 57, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7855), null, true, null, 94, "METZGER", null, null },
                    { 58, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7858), null, true, null, 95, "MAGNETI MARELLI", null, null },
                    { 59, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7861), null, true, null, 97, "WAECO", null, null },
                    { 60, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7864), null, true, null, 101, "FEBI BILSTEIN", null, null },
                    { 61, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7867), null, true, null, 106, "BRINK", null, null },
                    { 62, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7871), null, true, null, 109, "BUGATTI", null, null },
                    { 63, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7874), null, true, null, 110, "SNR", null, null },
                    { 64, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7877), null, true, null, 112, "EIBACH", null, null },
                    { 65, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7880), null, true, null, 113, "PAYEN", null, null },
                    { 66, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7884), null, true, null, 114, "BUDWEG CALIPER", null, null },
                    { 67, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7887), null, true, null, 115, "ULO", null, null },
                    { 68, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7890), null, true, null, 117, "LRT", null, null },
                    { 69, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7893), null, true, null, 118, "HJS", null, null },
                    { 70, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7896), null, true, null, 121, "METELLI", null, null },
                    { 71, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7900), null, true, null, 123, "NISSENS", null, null },
                    { 72, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7903), null, true, null, 126, "STABILUS", null, null },
                    { 73, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7907), null, true, null, 127, "NK", null, null },
                    { 74, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7918), null, true, null, 129, "OPTIMAL", null, null },
                    { 75, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7921), null, true, null, 135, "SIDEM", null, null },
                    { 76, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7925), null, true, null, 137, "UFI", null, null },
                    { 77, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7928), null, true, null, 138, "JOHNS", null, null },
                    { 78, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7931), null, true, null, 139, "AJUSA", null, null },
                    { 79, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7935), null, true, null, 140, "CORTECO", null, null },
                    { 80, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7938), null, true, null, 141, "AE", null, null },
                    { 81, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7941), null, true, null, 142, "SOFIMA", null, null },
                    { 82, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7944), null, true, null, 144, "MEYLE", null, null },
                    { 83, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7947), null, true, null, 151, "SWAG", null, null },
                    { 84, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7950), null, true, null, 154, "DOLZ", null, null },
                    { 85, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7954), null, true, null, 156, "JAPANPARTS", null, null },
                    { 86, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7957), null, true, null, 158, "ICER", null, null },
                    { 87, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7960), null, true, null, 159, "FACET", null, null },
                    { 88, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7963), null, true, null, 161, "TRW", null, null },
                    { 89, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7966), null, true, null, 162, "VAICO", null, null },
                    { 90, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7970), null, true, null, 166, "AISIN", null, null },
                    { 91, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7973), null, true, null, 167, "DUPLI COLOR", null, null },
                    { 92, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7976), null, true, null, 168, "MOTIP", null, null },
                    { 93, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7980), null, true, null, 169, "PRESTO", null, null },
                    { 94, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7983), null, true, null, 175, "LESJÖFORS", null, null },
                    { 95, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7986), null, true, null, 177, "BTS Turbo", null, null },
                    { 96, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7990), null, true, null, 178, "HEPU", null, null },
                    { 97, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7993), null, true, null, 180, "ALCO FILTER", null, null },
                    { 98, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7996), null, true, null, 181, "GK", null, null },
                    { 99, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7999), null, true, null, 182, "SCHLÜTTER TURBOLADER", null, null },
                    { 100, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8002), null, true, null, 183, "VEMO", null, null },
                    { 101, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8006), null, true, null, 185, "KAMOKA", null, null },
                    { 102, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8009), null, true, null, 191, "IMASAF", null, null },
                    { 103, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8012), null, true, null, 192, "FAG", null, null },
                    { 104, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8015), null, true, null, 197, "LPR", null, null },
                    { 105, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8018), null, true, null, 198, "OCAP", null, null },
                    { 106, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8021), null, true, null, 202, "GLYCO", null, null },
                    { 107, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8025), null, true, null, 204, "INA", null, null },
                    { 108, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8028), null, true, null, 205, "NRF", null, null },
                    { 109, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8031), null, true, null, 206, "A.B.S.", null, null },
                    { 110, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8034), null, true, null, 207, "CASTROL", null, null },
                    { 111, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8038), null, true, null, 209, "TRUCKTEC AUTOMOTIVE", null, null },
                    { 112, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8041), null, true, null, 214, "REMY", null, null },
                    { 113, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8045), null, true, null, 215, "CALORSTAT by Vernet", null, null },
                    { 114, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8048), null, true, null, 216, "NÜRAL", null, null },
                    { 115, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8051), null, true, null, 220, "AIRTEX", null, null },
                    { 116, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8054), null, true, null, 222, "LIQUI MOLY", null, null },
                    { 117, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8058), null, true, null, 225, "SCT - MANNOL", null, null },
                    { 118, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8061), null, true, null, 226, "ELSTOCK", null, null },
                    { 119, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8064), null, true, null, 233, "DINEX", null, null },
                    { 120, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8067), null, true, null, 234, "ERA", null, null },
                    { 121, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8070), null, true, null, 235, "FRECCIA", null, null },
                    { 122, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8074), null, true, null, 240, "FAE", null, null },
                    { 123, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8077), null, true, null, 244, "MEAT & DORIA", null, null },
                    { 124, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8080), null, true, null, 247, "AVA QUALITY COOLING", null, null },
                    { 125, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8083), null, true, null, 248, "NIPPARTS", null, null },
                    { 126, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8086), null, true, null, 256, "FILTRON", null, null },
                    { 127, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8089), null, true, null, 257, "ASHIKA", null, null },
                    { 128, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8092), null, true, null, 260, "SASIC", null, null },
                    { 129, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8095), null, true, null, 267, "FAI AutoParts", null, null },
                    { 130, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8099), null, true, null, 268, "JP GROUP", null, null },
                    { 131, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8102), null, true, null, 277, "AMC", null, null },
                    { 132, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8105), null, true, null, 287, "MAHLE", null, null },
                    { 133, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8110), null, true, null, 294, "SACHS PERFORMANCE", null, null },
                    { 134, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8114), null, true, null, 295, "fri.tech.", null, null },
                    { 135, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8117), null, true, null, 297, "sbs", null, null },
                    { 136, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8120), null, true, null, 299, "WEBASTO", null, null },
                    { 137, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8123), null, true, null, 300, "AUTEX", null, null },
                    { 138, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8126), null, true, null, 301, "TOPRAN", null, null },
                    { 139, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8129), null, true, null, 305, "K&N Filters", null, null },
                    { 140, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8132), null, true, null, 310, "GRAF", null, null },
                    { 141, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8136), null, true, null, 311, "CIFAM", null, null },
                    { 142, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8146), null, true, null, 316, "GENERAL RICAMBI", null, null },
                    { 143, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8150), null, true, null, 323, "AUTOMEGA", null, null },
                    { 144, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8154), null, true, null, 324, "WIX FILTERS", null, null },
                    { 145, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8157), null, true, null, 326, "BorgWarner (Schwitzer)", null, null },
                    { 146, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8160), null, true, null, 327, "BorgWarner", null, null },
                    { 147, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8163), null, true, null, 328, "BorgWarner (3K)", null, null },
                    { 148, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8167), null, true, null, 331, "ORIGINAL IMPERIUM", null, null },
                    { 149, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8170), null, true, null, 340, "PRASCO", null, null },
                    { 150, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8173), null, true, null, 347, "TRW Engine Component", null, null },
                    { 151, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8177), null, true, null, 350, "BLUE PRINT", null, null },
                    { 152, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8180), null, true, null, 351, "AUTOFREN SEINSA", null, null },
                    { 153, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8184), null, true, null, 356, "TESLA", null, null },
                    { 154, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8187), null, true, null, 362, "ALKAR", null, null },
                    { 155, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8191), null, true, null, 367, "FA1", null, null },
                    { 156, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8194), null, true, null, 373, "GSP", null, null },
                    { 157, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8198), null, true, null, 376, "CENTRA", null, null },
                    { 158, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8201), null, true, null, 377, "BOSCH DIAGNOSTICS", null, null },
                    { 159, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8204), null, true, null, 380, "FRENKIT", null, null },
                    { 160, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8207), null, true, null, 385, "GOETZE ENGINE", null, null },
                    { 161, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8211), null, true, null, 388, "MOTORAD", null, null },
                    { 162, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8214), null, true, null, 389, "GLYSANTIN", null, null },
                    { 163, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8217), null, true, null, 391, "EAI", null, null },
                    { 164, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8220), null, true, null, 394, "BARUM", null, null },
                    { 165, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8224), null, true, null, 397, "JANMOR", null, null },
                    { 166, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8227), null, true, null, 399, "EXEDY", null, null },
                    { 167, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8230), null, true, null, 400, "RAICAM", null, null },
                    { 168, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8233), null, true, null, 403, "MAXGEAR", null, null },
                    { 169, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8236), null, true, null, 406, "BM CATALYSTS", null, null },
                    { 170, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8240), null, true, null, 409, "FREMAX", null, null },
                    { 171, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8243), null, true, null, 427, "ASMET", null, null },
                    { 172, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8246), null, true, null, 430, "RTS", null, null },
                    { 173, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8250), null, true, null, 432, "KOLBENSCHMIDT", null, null },
                    { 174, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8254), null, true, null, 433, "STATIM", null, null },
                    { 175, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8257), null, true, null, 436, "MOTUL", null, null },
                    { 176, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8261), null, true, null, 437, "CoopersFiaam", null, null },
                    { 177, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8264), null, true, null, 443, "ENERGIZER", null, null },
                    { 178, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8267), null, true, null, 447, "PILKINGTON", null, null },
                    { 179, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8270), null, true, null, 449, "HITACHI", null, null },
                    { 180, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8274), null, true, null, 454, "BANDO", null, null },
                    { 181, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8277), null, true, null, 460, "DRI", null, null },
                    { 182, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8281), null, true, null, 461, "RAVENOL", null, null },
                    { 183, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8284), null, true, null, 464, "OSVAT", null, null },
                    { 184, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8287), null, true, null, 467, "CS Germany", null, null },
                    { 185, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8290), null, true, null, 475, "BORG & BECK", null, null },
                    { 186, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8294), null, true, null, 483, "ClimAir", null, null },
                    { 187, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8297), null, true, null, 485, "NARVA", null, null },
                    { 188, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8300), null, true, null, 494, "BRISK", null, null },
                    { 189, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8303), null, true, null, 499, "ZAFFO", null, null },
                    { 190, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8307), null, true, null, 4005, "EPS", null, null },
                    { 191, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8310), null, true, null, 4006, "KW", null, null },
                    { 192, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8313), null, true, null, 4023, "KS TOOLS", null, null },
                    { 193, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8317), null, true, null, 4026, "VIGOR", null, null },
                    { 194, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8321), null, true, null, 4314, "SHELL", null, null },
                    { 195, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8324), null, true, null, 4333, "Prestone", null, null },
                    { 196, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8328), null, true, null, 4344, "ELTA AUTOMOTIVE", null, null },
                    { 197, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8331), null, true, null, 4346, "VIKA", null, null },
                    { 198, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8334), null, true, null, 4353, "DPA", null, null },
                    { 199, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8338), null, true, null, 4367, "STOP&GO", null, null },
                    { 200, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8341), null, true, null, 4372, "PETEC", null, null },
                    { 201, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8344), null, true, null, 4381, "Airstal", null, null },
                    { 202, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8348), null, true, null, 4434, "CONTINENTAL", null, null },
                    { 203, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8351), null, true, null, 4436, "DUNLOP", null, null },
                    { 204, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8354), null, true, null, 4449, "MOBIL", null, null },
                    { 205, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8357), null, true, null, 4451, "YUASA", null, null },
                    { 206, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8360), null, true, null, 4452, "GS", null, null },
                    { 207, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8364), null, true, null, 4457, "SONAX", null, null },
                    { 208, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8368), null, true, null, 4512, "ERT", null, null },
                    { 209, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8372), null, true, null, 4514, "ET ENGINETEAM", null, null },
                    { 210, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8382), null, true, null, 4536, "LINEX", null, null },
                    { 211, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8386), null, true, null, 4539, "Arnott", null, null },
                    { 212, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8389), null, true, null, 4593, "TEDGUM", null, null },
                    { 213, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8392), null, true, null, 4612, "TUNGSRAM", null, null },
                    { 214, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8396), null, true, null, 4615, "GARRETT", null, null },
                    { 215, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8400), null, true, null, 4657, "ABAKUS", null, null },
                    { 216, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8403), null, true, null, 4676, "ROTINGER", null, null },
                    { 217, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8406), null, true, null, 4679, "CAFFARO", null, null },
                    { 218, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8410), null, true, null, 4705, "MOBILETRON", null, null },
                    { 219, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8413), null, true, null, 4717, "NE", null, null },
                    { 220, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8416), null, true, null, 4719, "LIFT-TEK", null, null },
                    { 221, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8419), null, true, null, 4721, "MIRAGLIO", null, null },
                    { 222, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8423), null, true, null, 4734, "HELLA GUTMANN", null, null },
                    { 223, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8426), null, true, null, 4808, "HAZET", null, null },
                    { 224, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8429), null, true, null, 4815, "Borsehung", null, null },
                    { 225, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8432), null, true, null, 4821, "QUARO", null, null },
                    { 226, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8436), null, true, null, 4843, "AS-PL", null, null },
                    { 227, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8439), null, true, null, 4849, "Ac Rolcar", null, null },
                    { 228, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8442), null, true, null, 4866, "ARAL", null, null },
                    { 229, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8446), null, true, null, 4871, "COFLE", null, null },
                    { 230, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8449), null, true, null, 4873, "POLMO", null, null },
                    { 231, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8452), null, true, null, 4881, "DYNAMAX", null, null },
                    { 232, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8455), null, true, null, 4911, "ALLIGATOR", null, null },
                    { 233, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8459), null, true, null, 4912, "GEDORE", null, null },
                    { 234, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8463), null, true, null, 4923, "NORMA", null, null },
                    { 235, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8466), null, true, null, 4946, "SCHRADER", null, null },
                    { 236, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8469), null, true, null, 4949, "TURBORAIL", null, null },
                    { 237, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8473), null, true, null, 4969, "ESEN SKV", null, null },
                    { 238, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8476), null, true, null, 5251, "HART", null, null },
                    { 239, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8479), null, true, null, 6102, "ACPS-ORIS", null, null },
                    { 240, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8482), null, true, null, 6186, "VALVOLINE", null, null },
                    { 241, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8486), null, true, null, 6263, "CPB", null, null },
                    { 242, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8489), null, true, null, 6304, "QUICK BRAKE", null, null },
                    { 243, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8492), null, true, null, 6306, "GKN", null, null },
                    { 244, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8495), null, true, null, 6343, "REPSOL", null, null },
                    { 245, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8499), null, true, null, 6368, "EBC Brakes", null, null },
                    { 246, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8503), null, true, null, 6441, "BERU by DRiV", null, null },
                    { 247, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8506), null, true, null, 6444, "BorgWarner (AWD)", null, null },
                    { 248, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8509), null, true, null, 6534, "Dr.Motor Automotive", null, null },
                    { 249, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8512), null, true, null, 6558, "AIC", null, null },
                    { 250, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8515), null, true, null, 6984, "Oyodo", null, null },
                    { 251, null, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(8519), null, true, null, 6985, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CreateDate", "CurrencyCode", "CurrencyName", "IsActive", "NumericCurrencyCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 17, 16, 8, 24, 469, DateTimeKind.Local).AddTicks(1217), "CZK", "Česká koruna", true, 203, null },
                    { 2, new DateTime(2023, 11, 17, 16, 8, 24, 469, DateTimeKind.Local).AddTicks(1247), "EUR", "Euro", true, 978, null },
                    { 3, new DateTime(2023, 11, 17, 16, 8, 24, 469, DateTimeKind.Local).AddTicks(1252), "PLN", "Złoty", true, 985, null }
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2780), true, "6 měsíců", null },
                    { 2, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2810), true, "12 měsíců", null },
                    { 3, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2814), true, "24 měsíců", null },
                    { 4, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2817), true, "36 měsíců", null },
                    { 5, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2820), true, "48 měsíců", null },
                    { 6, new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(2823), true, "60 měsíců", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryNameCZ", "CountryNameENG", "CreateDate", "CurrencyId", "ISOAlpha2", "ISOAlpha3", "IsActive", "NumericCountryCode", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Česká republika", "Czech Republic", new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(7207), 1, "CZ", "CZE", true, 203, null },
                    { 2, "Slovenská republika", "Slovakia", new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(7242), 2, "SK", "SVK", true, 703, null },
                    { 3, "Polsko", "Poland", new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(7247), 3, "PL", "POL", true, 616, null },
                    { 4, "Německo", "Germany", new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(7251), 2, "DE", "DEU", true, 276, null },
                    { 5, "Rakousko", "Austria", new DateTime(2023, 11, 17, 16, 8, 24, 468, DateTimeKind.Local).AddTicks(7254), 2, "AT", "AUT", true, 40, null }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CountryId", "CreateDate", "GeneralInformation", "IsActive", "LogoPath", "TecDoc", "Title", "UpdateDate", "WebSite" },
                values: new object[] { 1, 4, new DateTime(2023, 11, 17, 16, 8, 24, 467, DateTimeKind.Local).AddTicks(7596), "Test", true, null, 1, "SPIDAN", null, "https://www.spidanchassisparts.com/" });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CountryId",
                table: "Brands",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
