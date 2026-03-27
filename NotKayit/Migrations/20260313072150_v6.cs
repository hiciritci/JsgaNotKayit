using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotKayit.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotTml_NotKodTml_NotKodId",
                table: "NotTml");

            migrationBuilder.DropForeignKey(
                name: "FK_NotTml_OgrenciTml_OgrenciId",
                table: "NotTml");

            migrationBuilder.DropIndex(
                name: "IX_NotTml_NotKodId",
                table: "NotTml");

            migrationBuilder.DropIndex(
                name: "IX_NotTml_OgrenciId",
                table: "NotTml");

            migrationBuilder.DropColumn(
                name: "NotKodId",
                table: "NotTml");

            migrationBuilder.DropColumn(
                name: "OgrenciId",
                table: "NotTml");

            migrationBuilder.AlterColumn<long>(
                name: "OgrenciTmlId",
                table: "NotTml",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "NotKodTmlId",
                table: "NotTml",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_NotKodTmlId",
                table: "NotTml",
                column: "NotKodTmlId");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_OgrenciTmlId",
                table: "NotTml",
                column: "OgrenciTmlId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotTml_NotKodTml_NotKodTmlId",
                table: "NotTml",
                column: "NotKodTmlId",
                principalTable: "NotKodTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotTml_OgrenciTml_OgrenciTmlId",
                table: "NotTml",
                column: "OgrenciTmlId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotTml_NotKodTml_NotKodTmlId",
                table: "NotTml");

            migrationBuilder.DropForeignKey(
                name: "FK_NotTml_OgrenciTml_OgrenciTmlId",
                table: "NotTml");

            migrationBuilder.DropIndex(
                name: "IX_NotTml_NotKodTmlId",
                table: "NotTml");

            migrationBuilder.DropIndex(
                name: "IX_NotTml_OgrenciTmlId",
                table: "NotTml");

            migrationBuilder.AlterColumn<int>(
                name: "OgrenciTmlId",
                table: "NotTml",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "NotKodTmlId",
                table: "NotTml",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "NotKodId",
                table: "NotTml",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "OgrenciId",
                table: "NotTml",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_NotKodId",
                table: "NotTml",
                column: "NotKodId");

            migrationBuilder.CreateIndex(
                name: "IX_NotTml_OgrenciId",
                table: "NotTml",
                column: "OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotTml_NotKodTml_NotKodId",
                table: "NotTml",
                column: "NotKodId",
                principalTable: "NotKodTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotTml_OgrenciTml_OgrenciId",
                table: "NotTml",
                column: "OgrenciId",
                principalTable: "OgrenciTml",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
