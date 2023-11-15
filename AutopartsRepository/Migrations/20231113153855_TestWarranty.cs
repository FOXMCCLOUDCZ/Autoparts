using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutopartsRepository.Migrations
{
    /// <inheritdoc />
    public partial class TestWarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdateDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Warranties",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "13.11.2023", true, "6 měsíců", null },
                    { 2, "13.11.2023", true, "12 měsíců", null },
                    { 3, "13.11.2023", true, "24 měsíců", null },
                    { 4, "13.11.2023", true, "36 měsíců", null },
                    { 5, "13.11.2023", true, "48 měsíců", null },
                    { 6, "13.11.2023", true, "60 měsíců", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warranties");
        }
    }
}
