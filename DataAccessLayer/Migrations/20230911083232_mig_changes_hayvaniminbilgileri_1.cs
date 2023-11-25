using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migchangeshayvaniminbilgileri1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklamasi",
                table: "hayvaniminBilgileris");

            migrationBuilder.DropColumn(
                name: "HerhangiBirHastaligiVarmi",
                table: "hayvaniminBilgileris");

            migrationBuilder.AlterColumn<string>(
                name: "KullanilanTakviyeveVitaminVarmi",
                table: "hayvaniminBilgileris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "KullanilanTakviyeveVitaminVarmi",
                table: "hayvaniminBilgileris",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklamasi",
                table: "hayvaniminBilgileris",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HerhangiBirHastaligiVarmi",
                table: "hayvaniminBilgileris",
                type: "bit",
                nullable: true);
        }
    }
}
