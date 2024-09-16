using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_308 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    hazaiVeg = table.Column<int>(type: "INTEGER", nullable: false),
                    vendegVeg = table.Column<int>(type: "INTEGER", nullable: false),
                    hazaiGolFelidoben = table.Column<int>(type: "INTEGER", nullable: false),
                    vendegGolFelidoben = table.Column<int>(type: "INTEGER", nullable: false),
                    hazaiCsapatnev = table.Column<string>(type: "TEXT", nullable: false),
                    vendegCsapatnev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
