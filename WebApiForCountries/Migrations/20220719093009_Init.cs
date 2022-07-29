using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiForCountries.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Short_form_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Long_form_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENC2A_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENC3A_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
