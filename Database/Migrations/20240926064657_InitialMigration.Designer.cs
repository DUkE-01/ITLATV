﻿// <auto-generated />
using Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240926064657_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContenidoGeneros", b =>
                {
                    b.Property<int>("ContenidoId")
                        .HasColumnType("int");

                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.HasKey("ContenidoId", "GenerosId");

                    b.HasIndex("GenerosId");

                    b.ToTable("ContenidoGeneros");
                });

            modelBuilder.Entity("Database.Entities.Contenido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnlaceVideo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<string>("ImagenPortada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ProductoraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoraId");

                    b.ToTable("Contenidos", (string)null);
                });

            modelBuilder.Entity("Database.Entities.Generos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContenidoId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Generos", (string)null);
                });

            modelBuilder.Entity("Database.Entities.Productora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Productoras", (string)null);
                });

            modelBuilder.Entity("ContenidoGeneros", b =>
                {
                    b.HasOne("Database.Entities.Contenido", null)
                        .WithMany()
                        .HasForeignKey("ContenidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entities.Generos", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Database.Entities.Contenido", b =>
                {
                    b.HasOne("Database.Entities.Productora", "Productora")
                        .WithMany("Contenido")
                        .HasForeignKey("ProductoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Productora");
                });

            modelBuilder.Entity("Database.Entities.Productora", b =>
                {
                    b.Navigation("Contenido");
                });
#pragma warning restore 612, 618
        }
    }
}
