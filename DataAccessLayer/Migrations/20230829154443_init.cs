using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asiTakibis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YapilanAsininTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsininYapildigiTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asiTakibis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "beslenmeTakibis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullandigiMamaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MamaMarkasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MamaAromasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UygunOlanOgunMiktari = table.Column<int>(type: "int", nullable: false),
                    AlerjikReaksiyonGosterdigiBesinler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullandigiOdulMamalari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeSikliklaVeriliyor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuTuketimOrani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YemekSaatiUyarisi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beslenmeTakibis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hayvaniminBilgileris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SahiplenildigiTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cinsiyeti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kilosu = table.Column<int>(type: "int", nullable: false),
                    HerhangiBirHastaligiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    HastalikAciklamaveKullandigiIlaclar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullanilanTakviyeveVitaminVarmi = table.Column<bool>(type: "bit", nullable: false),
                    Aciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Irki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisirlastirilmismi = table.Column<bool>(type: "bit", nullable: false),
                    AyniEvdeYasayanBaskaHayvanVarmi = table.Column<bool>(type: "bit", nullable: false),
                    TakipCipiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hayvaniminBilgileris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "saglikTakibis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuzenliOlarakGidilenVeterinerVarmi = table.Column<bool>(type: "bit", nullable: false),
                    VeterinerAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlinikTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlinikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlinikAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvaninizinKiloDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KalitsalHastalik = table.Column<bool>(type: "bit", nullable: false),
                    KalitsalHastalikAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeciciHastalikVarmi = table.Column<bool>(type: "bit", nullable: false),
                    GeciciHastalikAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvcilHayvaninizdaGozlemlediginizFarklilik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarklilikAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saglikTakibis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sosyalAktiviteleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyuncaklarlaIlgilenirmi = table.Column<bool>(type: "bit", nullable: false),
                    DisariCikiyormu = table.Column<bool>(type: "bit", nullable: false),
                    NeSikliklaCikiyor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeyahetEdermisiniz = table.Column<bool>(type: "bit", nullable: false),
                    NeSikliklaSeyaheteCikiyorsunuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvaniniziMutluEdenSeyler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvaniniziOfkelendirenSeyler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnuSakinlestirmekIcinKullandiginizYontemler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OyunOynamaZamaniUyarisi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sosyalAktiviteleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "temizlikTakibis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TirnaklariNeSikliklaKesiyorsunuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgizBakimiNeSikliklaYapiliyor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KulakTemizligiNeSikliklaYapiliyor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenelTemizlikTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeSikliklaYikiyorsunuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeSikliklaTuyleriniTararsiniz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeSikliklaPatiBakimiYapiyorsunuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakimTakipUyarisi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temizlikTakibis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asiTakibis");

            migrationBuilder.DropTable(
                name: "beslenmeTakibis");

            migrationBuilder.DropTable(
                name: "hayvaniminBilgileris");

            migrationBuilder.DropTable(
                name: "saglikTakibis");

            migrationBuilder.DropTable(
                name: "sosyalAktiviteleris");

            migrationBuilder.DropTable(
                name: "temizlikTakibis");
        }
    }
}
