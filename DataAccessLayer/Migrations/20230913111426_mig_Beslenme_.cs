using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migBeslenme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullandigiOdulMamalari",
                table: "beslenmeTakibis");

            migrationBuilder.DropColumn(
                name: "NeSikliklaVeriliyor",
                table: "beslenmeTakibis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KullandigiOdulMamalari",
                table: "beslenmeTakibis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeSikliklaVeriliyor",
                table: "beslenmeTakibis",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
