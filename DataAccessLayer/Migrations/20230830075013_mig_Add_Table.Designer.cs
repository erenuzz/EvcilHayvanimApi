﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(EvcilDbContext))]
    [Migration("20230830075013_mig_Add_Table")]
    partial class migAddTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.AsiTakibi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AsininYapildigiTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("YapilanAsininTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("asiTakibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BeslenmeTakibi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlerjikReaksiyonGosterdigiBesinler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullandigiMamaTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullandigiOdulMamalari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MamaAromasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MamaMarkasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaVeriliyor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuTuketimOrani")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UygunOlanOgunMiktari")
                        .HasColumnType("int");

                    b.Property<DateTime>("YemekSaatiUyarisi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("beslenmeTakibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EvcilHayvanlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HayvaninAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EvcilHayvanlar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HayvaniminBilgileri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AyniEvdeYasayanBaskaHayvanVarmi")
                        .HasColumnType("bit");

                    b.Property<string>("Cinsiyeti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("EvcilHayvanlarId")
                        .HasColumnType("int");

                    b.Property<string>("HastalikAciklamaveKullandigiIlaclar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HerhangiBirHastaligiVarmi")
                        .HasColumnType("bit");

                    b.Property<string>("Irki")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kilosu")
                        .HasColumnType("int");

                    b.Property<bool>("Kisirlastirilmismi")
                        .HasColumnType("bit");

                    b.Property<bool>("KullanilanTakviyeveVitaminVarmi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SahiplenildigiTarih")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TakipCipiVarmi")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Yasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EvcilHayvanlarId");

                    b.ToTable("hayvaniminBilgileris");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SaglikTakibi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DuzenliOlarakGidilenVeterinerVarmi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EvcilHayvaninizdaGozlemlediginizFarklilik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeciciHastalikAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GeciciHastalikVarmi")
                        .HasColumnType("bit");

                    b.Property<string>("HayvaninizinKiloDurumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KalitsalHastalik")
                        .HasColumnType("bit");

                    b.Property<string>("KalitsalHastalikAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KlinikAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KlinikAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KlinikTelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VeterinerAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("saglikTakibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SosyalAktiviteleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DisariCikiyormu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HayvaniniziMutluEdenSeyler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HayvaniniziOfkelendirenSeyler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaCikiyor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaSeyaheteCikiyorsunuz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnuSakinlestirmekIcinKullandiginizYontemler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OyunOynamaZamaniUyarisi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OyuncaklarlaIlgilenirmi")
                        .HasColumnType("bit");

                    b.Property<bool>("SeyahetEdermisiniz")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("sosyalAktiviteleris");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TemizlikTakibi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AgizBakimiNeSikliklaYapiliyor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BakimTakipUyarisi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GenelTemizlikTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KulakTemizligiNeSikliklaYapiliyor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaPatiBakimiYapiyorsunuz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaTuyleriniTararsiniz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NeSikliklaYikiyorsunuz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TirnaklariNeSikliklaKesiyorsunuz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("temizlikTakibis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HayvaniminBilgileri", b =>
                {
                    b.HasOne("EntityLayer.Concrete.EvcilHayvanlar", "EvcilHayvanlar")
                        .WithMany()
                        .HasForeignKey("EvcilHayvanlarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvcilHayvanlar");
                });
#pragma warning restore 612, 618
        }
    }
}