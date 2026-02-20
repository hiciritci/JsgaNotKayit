using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotKayit.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "OgrenciTml",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "OgrenciIletisim",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DersAlanKodTml",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAlanKodTml", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciAdres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciTmlId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OgrenciId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciAdres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciAdres_OgrenciTml_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "OgrenciTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersTml",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KrediSayisi = table.Column<short>(type: "smallint", nullable: false),
                    DersAlanKodId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersTml", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DersTml_DersAlanKodTml_DersAlanKodId",
                        column: x => x.DersAlanKodId,
                        principalTable: "DersAlanKodTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotTml",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciTmlId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    NotKodTmlId = table.Column<int>(type: "int", nullable: false),
                    Deger = table.Column<double>(type: "float", nullable: false),
                    OgrenciId = table.Column<long>(type: "bigint", nullable: false),
                    NotKodId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotTml", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotTml_DersTml_DersId",
                        column: x => x.DersId,
                        principalTable: "DersTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotTml_NotKodTml_NotKodId",
                        column: x => x.NotKodId,
                        principalTable: "NotKodTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotTml_OgrenciTml_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "OgrenciTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciTmlId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_DersTml_DersId",
                        column: x => x.DersId,
                        principalTable: "DersTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_OgrenciTml_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "OgrenciTml",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersTml_DersAlanKodId",
                table: "DersTml",
                column: "DersAlanKodId");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_DersId",
                table: "NotTml",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_NotKodId",
                table: "NotTml",
                column: "NotKodId");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_OgrenciId",
                table: "NotTml",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciAdres_OgrenciId",
                table: "OgrenciAdres",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_DersId",
                table: "OgrenciDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_OgrenciId",
                table: "OgrenciDers",
                column: "OgrenciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotTml");

            migrationBuilder.DropTable(
                name: "OgrenciAdres");

            migrationBuilder.DropTable(
                name: "OgrenciDers");

            migrationBuilder.DropTable(
                name: "DersTml");

            migrationBuilder.DropTable(
                name: "DersAlanKodTml");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "OgrenciTml");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "OgrenciIletisim");
        }
    }
}
