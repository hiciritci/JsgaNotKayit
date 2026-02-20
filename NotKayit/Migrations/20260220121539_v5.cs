using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotKayit.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersTml_DersAlanKodTml_DersAlanKodId",
                table: "DersTml");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciAdres_OgrenciTml_OgrenciId",
                table: "OgrenciAdres");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_DersTml_DersId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_OgrenciTml_OgrenciId",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciDers_OgrenciId",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciAdres_OgrenciId",
                table: "OgrenciAdres");

            migrationBuilder.DropColumn(
                name: "OgrenciId",
                table: "OgrenciDers");

            migrationBuilder.DropColumn(
                name: "OgrenciId",
                table: "OgrenciAdres");

            migrationBuilder.RenameColumn(
                name: "DersId",
                table: "OgrenciDers",
                newName: "DersTmlId");

            migrationBuilder.RenameIndex(
                name: "IX_OgrenciDers_DersId",
                table: "OgrenciDers",
                newName: "IX_OgrenciDers_DersTmlId");

            migrationBuilder.RenameColumn(
                name: "DersAlanKodId",
                table: "DersTml",
                newName: "DersAlanKodTmlId");

            migrationBuilder.RenameIndex(
                name: "IX_DersTml_DersAlanKodId",
                table: "DersTml",
                newName: "IX_DersTml_DersAlanKodTmlId");

            migrationBuilder.AlterColumn<long>(
                name: "OgrenciTmlId",
                table: "OgrenciDers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "OgrenciTmlId",
                table: "OgrenciAdres",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_OgrenciTmlId",
                table: "OgrenciDers",
                column: "OgrenciTmlId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciAdres_OgrenciTmlId",
                table: "OgrenciAdres",
                column: "OgrenciTmlId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersTml_DersAlanKodTml_DersAlanKodTmlId",
                table: "DersTml",
                column: "DersAlanKodTmlId",
                principalTable: "DersAlanKodTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciAdres_OgrenciTml_OgrenciTmlId",
                table: "OgrenciAdres",
                column: "OgrenciTmlId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_DersTml_DersTmlId",
                table: "OgrenciDers",
                column: "DersTmlId",
                principalTable: "DersTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_OgrenciTml_OgrenciTmlId",
                table: "OgrenciDers",
                column: "OgrenciTmlId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersTml_DersAlanKodTml_DersAlanKodTmlId",
                table: "DersTml");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciAdres_OgrenciTml_OgrenciTmlId",
                table: "OgrenciAdres");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_DersTml_DersTmlId",
                table: "OgrenciDers");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_OgrenciTml_OgrenciTmlId",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciDers_OgrenciTmlId",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciAdres_OgrenciTmlId",
                table: "OgrenciAdres");

            migrationBuilder.RenameColumn(
                name: "DersTmlId",
                table: "OgrenciDers",
                newName: "DersId");

            migrationBuilder.RenameIndex(
                name: "IX_OgrenciDers_DersTmlId",
                table: "OgrenciDers",
                newName: "IX_OgrenciDers_DersId");

            migrationBuilder.RenameColumn(
                name: "DersAlanKodTmlId",
                table: "DersTml",
                newName: "DersAlanKodId");

            migrationBuilder.RenameIndex(
                name: "IX_DersTml_DersAlanKodTmlId",
                table: "DersTml",
                newName: "IX_DersTml_DersAlanKodId");

            migrationBuilder.AlterColumn<int>(
                name: "OgrenciTmlId",
                table: "OgrenciDers",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "OgrenciId",
                table: "OgrenciDers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "OgrenciTmlId",
                table: "OgrenciAdres",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "OgrenciId",
                table: "OgrenciAdres",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_OgrenciId",
                table: "OgrenciDers",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciAdres_OgrenciId",
                table: "OgrenciAdres",
                column: "OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersTml_DersAlanKodTml_DersAlanKodId",
                table: "DersTml",
                column: "DersAlanKodId",
                principalTable: "DersAlanKodTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciAdres_OgrenciTml_OgrenciId",
                table: "OgrenciAdres",
                column: "OgrenciId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_DersTml_DersId",
                table: "OgrenciDers",
                column: "DersId",
                principalTable: "DersTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_OgrenciTml_OgrenciId",
                table: "OgrenciDers",
                column: "OgrenciId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
