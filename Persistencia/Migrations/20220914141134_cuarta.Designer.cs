﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220914141134_cuarta")]
    partial class cuarta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Colegio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Licencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Modalidad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId")
                        .IsUnique();

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Jugadores")
                        .HasColumnType("int");

                    b.Property<string>("Modalidades")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PatrocinadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.HasIndex("PatrocinadorId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Patrocinadores");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Equipos")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fixture")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Modalidad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.HasKey("TorneoId", "EquipoId");

                    b.HasIndex("EquipoId");

                    b.ToTable("TorneoEquipos");
                });

            modelBuilder.Entity("Dominio.UnidadDeportiva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TorneoId");

                    b.ToTable("UnidadDeportivas");
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.HasOne("Dominio.Equipo", null)
                        .WithOne("Tecnico")
                        .HasForeignKey("Dominio.Entrenador", "EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.HasOne("Dominio.Patrocinador", null)
                        .WithMany("Equipos")
                        .HasForeignKey("PatrocinadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.HasOne("Dominio.Municipio", null)
                        .WithMany("Torneos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.HasOne("Dominio.Equipo", "Equipo")
                        .WithMany("TorneoEquipos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Torneo", "Torneo")
                        .WithMany("TorneoEquipos")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Dominio.UnidadDeportiva", b =>
                {
                    b.HasOne("Dominio.Torneo", null)
                        .WithMany("UnidadDeportivas")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Navigation("Tecnico")
                        .IsRequired();

                    b.Navigation("TorneoEquipos");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Navigation("Torneos");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Navigation("TorneoEquipos");

                    b.Navigation("UnidadDeportivas");
                });
#pragma warning restore 612, 618
        }
    }
}
