using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcialAmina.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suerte",
                columns: table => new
                {
                    FuturoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suerte", x => x.FuturoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suerte");
        }
    }
}
