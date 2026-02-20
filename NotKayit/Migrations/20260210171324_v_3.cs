using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotKayit.Migrations
{
    /// <inheritdoc />
    public partial class v_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotKodTml",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotKodTml", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciIletisim",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<long>(type: "bigint", nullable: false),
                    OgrenciTmlId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciIletisim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciIletisim_OgrenciTml_OgrenciTmlId",
                        column: x => x.OgrenciTmlId,
                        principalTable: "OgrenciTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciIletisim_OgrenciTmlId",
                table: "OgrenciIletisim",
                column: "OgrenciTmlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotKodTml");

            migrationBuilder.DropTable(
                name: "OgrenciIletisim");
        }
    }
}
