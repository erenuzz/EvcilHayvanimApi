using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migAddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FarklilikAciklamasi",
                table: "saglikTakibis");

            migrationBuilder.AlterColumn<string>(
                name: "NeSikliklaSeyaheteCikiyorsunuz",
                table: "sosyalAktiviteleris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NeSikliklaCikiyor",
                table: "sosyalAktiviteleris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "asiTakibis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EvcilHayvanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvaninAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvcilHayvanlar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hayvaniminBilgileris_EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                column: "EvcilHayvanlarId");

            migrationBuilder.AddForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris",
                column: "EvcilHayvanlarId",
                principalTable: "EvcilHayvanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hayvaniminBilgileris_EvcilHayvanlar_EvcilHayvanlarId",
                table: "hayvaniminBilgileris");

            migrationBuilder.DropTable(
                name: "EvcilHayvanlar");

            migrationBuilder.DropIndex(
                name: "IX_hayvaniminBilgileris_EvcilHayvanlarId",
                table: "hayvaniminBilgileris");

            migrationBuilder.DropColumn(
                name: "EvcilHayvanlarId",
                table: "hayvaniminBilgileris");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "asiTakibis");

            migrationBuilder.AlterColumn<string>(
                name: "NeSikliklaSeyaheteCikiyorsunuz",
                table: "sosyalAktiviteleris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NeSikliklaCikiyor",
                table: "sosyalAktiviteleris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FarklilikAciklamasi",
                table: "saglikTakibis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
