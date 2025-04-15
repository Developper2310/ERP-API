﻿// <auto-generated />
using System;
using Demo1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Demo1.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Demo1.Model.AlimSatim", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int>("CalisanID")
                        .HasColumnType("integer");

                    b.Property<int?>("CalisanId")
                        .HasColumnType("integer");

                    b.Property<int>("DepoID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("IslemTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IslemTipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CalisanID");

                    b.HasIndex("CalisanId")
                        .IsUnique();

                    b.ToTable("AlimSatimlar");
                });

            modelBuilder.Entity("Demo1.Model.Calisan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DepartmanID")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("IseBaslamaTarihi")
                        .HasMaxLength(200)
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("Demo1.Model.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("Demo1.Model.Depo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("DepoAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.HasKey("Id");

                    b.ToTable("Depolar");
                });

            modelBuilder.Entity("Demo1.Model.DepoUrun", b =>
                {
                    b.Property<int>("UrunID")
                        .HasColumnType("integer");

                    b.Property<int>("DepoId")
                        .HasColumnType("integer");

                    b.Property<int>("Miktar")
                        .HasColumnType("integer");

                    b.HasKey("UrunID", "DepoId");

                    b.HasIndex("DepoId");

                    b.ToTable("DepoUrunler");
                });

            modelBuilder.Entity("Demo1.Model.FisDestek", b =>
                {
                    b.Property<int>("UrunID")
                        .HasColumnType("integer");

                    b.Property<int>("AlimSatimID")
                        .HasColumnType("integer");

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.HasKey("UrunID", "AlimSatimID");

                    b.HasIndex("AlimSatimID");

                    b.ToTable("FisDestekler");
                });

            modelBuilder.Entity("Demo1.Model.Islem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IslemAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Islemler");
                });

            modelBuilder.Entity("Demo1.Model.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciIslem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CalisanID")
                        .HasColumnType("integer");

                    b.Property<int>("IslemID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("IslemTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CalisanID");

                    b.HasIndex("IslemID");

                    b.ToTable("KullaniciIslemler");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciRol", b =>
                {
                    b.Property<int>("RolID")
                        .HasColumnType("integer");

                    b.Property<int>("CalisanID")
                        .HasColumnType("integer");

                    b.HasKey("RolID", "CalisanID");

                    b.HasIndex("CalisanID");

                    b.ToTable("KullaniciRoller");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciSifre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Aktif")
                        .HasColumnType("boolean");

                    b.Property<int>("CalisanID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CalisanID");

                    b.ToTable("KullaniciSifreleri");
                });

            modelBuilder.Entity("Demo1.Model.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MarkaAdi")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("character varying(70)");

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("Demo1.Model.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("RolAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("Demo1.Model.RolYetki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RolID")
                        .HasColumnType("integer");

                    b.Property<int>("YetkiID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RolID");

                    b.HasIndex("YetkiID");

                    b.ToTable("RolYetkileri");
                });

            modelBuilder.Entity("Demo1.Model.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("numeric");

                    b.Property<int>("KategoriID")
                        .HasColumnType("integer");

                    b.Property<int>("MarkaID")
                        .HasColumnType("integer");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("character varying(70)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("KategoriID");

                    b.HasIndex("MarkaID");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Demo1.Model.Yetki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("YetkiAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Yetkiler");
                });

            modelBuilder.Entity("Demo1.Model.AlimSatim", b =>
                {
                    b.HasOne("Demo1.Model.Calisan", "Calisan")
                        .WithMany("AlimSatimlar")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Calisan", null)
                        .WithOne("AlimSatim")
                        .HasForeignKey("Demo1.Model.AlimSatim", "CalisanId");

                    b.HasOne("Demo1.Model.Depo", "Depo")
                        .WithMany("AlimSatimlar")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Depo");
                });

            modelBuilder.Entity("Demo1.Model.Calisan", b =>
                {
                    b.HasOne("Demo1.Model.Departman", "Departman")
                        .WithMany("Calisanlar")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("Demo1.Model.DepoUrun", b =>
                {
                    b.HasOne("Demo1.Model.Depo", "Depo")
                        .WithMany("DepoUrunleri")
                        .HasForeignKey("DepoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Urun", "Urun")
                        .WithMany("DepoUrunleri")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depo");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Demo1.Model.FisDestek", b =>
                {
                    b.HasOne("Demo1.Model.AlimSatim", "AlimSatim")
                        .WithMany("FisDestekler")
                        .HasForeignKey("AlimSatimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Urun", "Urun")
                        .WithMany("FisDestekler")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlimSatim");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciIslem", b =>
                {
                    b.HasOne("Demo1.Model.Calisan", "Calisan")
                        .WithMany("KullaniciIslemleri")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Islem", "Islem")
                        .WithMany("KullaniciIslemleri")
                        .HasForeignKey("IslemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Islem");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciRol", b =>
                {
                    b.HasOne("Demo1.Model.Calisan", "Calisan")
                        .WithMany("KullaniciRolleri")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Rol", "Rol")
                        .WithMany("KullaniciRolleri")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Demo1.Model.KullaniciSifre", b =>
                {
                    b.HasOne("Demo1.Model.Calisan", "Calisan")
                        .WithMany("KullaniciSifreleri")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");
                });

            modelBuilder.Entity("Demo1.Model.RolYetki", b =>
                {
                    b.HasOne("Demo1.Model.Rol", "Rol")
                        .WithMany("RolYetkileri")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Yetki", "Yetki")
                        .WithMany("RolYetkileri")
                        .HasForeignKey("YetkiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Yetki");
                });

            modelBuilder.Entity("Demo1.Model.Urun", b =>
                {
                    b.HasOne("Demo1.Model.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo1.Model.Marka", "Marka")
                        .WithMany("Urunler")
                        .HasForeignKey("MarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("Demo1.Model.AlimSatim", b =>
                {
                    b.Navigation("FisDestekler");
                });

            modelBuilder.Entity("Demo1.Model.Calisan", b =>
                {
                    b.Navigation("AlimSatim");

                    b.Navigation("AlimSatimlar");

                    b.Navigation("KullaniciIslemleri");

                    b.Navigation("KullaniciRolleri");

                    b.Navigation("KullaniciSifreleri");
                });

            modelBuilder.Entity("Demo1.Model.Departman", b =>
                {
                    b.Navigation("Calisanlar");
                });

            modelBuilder.Entity("Demo1.Model.Depo", b =>
                {
                    b.Navigation("AlimSatimlar");

                    b.Navigation("DepoUrunleri");
                });

            modelBuilder.Entity("Demo1.Model.Islem", b =>
                {
                    b.Navigation("KullaniciIslemleri");
                });

            modelBuilder.Entity("Demo1.Model.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("Demo1.Model.Marka", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("Demo1.Model.Rol", b =>
                {
                    b.Navigation("KullaniciRolleri");

                    b.Navigation("RolYetkileri");
                });

            modelBuilder.Entity("Demo1.Model.Urun", b =>
                {
                    b.Navigation("DepoUrunleri");

                    b.Navigation("FisDestekler");
                });

            modelBuilder.Entity("Demo1.Model.Yetki", b =>
                {
                    b.Navigation("RolYetkileri");
                });
#pragma warning restore 612, 618
        }
    }
}
