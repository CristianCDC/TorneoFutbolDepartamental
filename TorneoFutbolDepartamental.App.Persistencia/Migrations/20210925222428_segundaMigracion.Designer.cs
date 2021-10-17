﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoFutbolDepartamental.App.Persistencia;

namespace TorneoFutbolDepartamental.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210925222428_segundaMigracion")]
    partial class segundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DirectorTecnicoPersonaId")
                        .HasColumnType("int");

                    b.Property<int>("GolesContra")
                        .HasColumnType("int");

                    b.Property<int>("GolesFavor")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.Property<int>("cntPartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("cntPartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("cntPartidosJugados")
                        .HasColumnType("int");

                    b.HasKey("EquipoId");

                    b.HasIndex("DirectorTecnicoPersonaId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("EstadioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadioId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MunicipioId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Partido", b =>
                {
                    b.Property<int>("PartidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ArbitroPersonaId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoLocalEquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoVisitanteEquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadioId")
                        .HasColumnType("int");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marcador")
                        .HasColumnType("int");

                    b.HasKey("PartidoId");

                    b.HasIndex("ArbitroPersonaId");

                    b.HasIndex("EquipoLocalEquipoId");

                    b.HasIndex("EquipoVisitanteEquipoId");

                    b.HasIndex("EstadioId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Arbitro", b =>
                {
                    b.HasBaseType("TorneoFutbolDepartamental.App.Dominio.Persona");

                    b.Property<string>("ColegioPertenece")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdArbitro")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Arbitro");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.DirectorTecnico", b =>
                {
                    b.HasBaseType("TorneoFutbolDepartamental.App.Dominio.Persona");

                    b.Property<string>("Equipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DirectorTecnico_Equipo");

                    b.Property<int>("IdTecnico")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("DirectorTecnico");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Jugador", b =>
                {
                    b.HasBaseType("TorneoFutbolDepartamental.App.Dominio.Persona");

                    b.Property<string>("Equipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Jugador");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.DirectorTecnico", "DirectorTecnico")
                        .WithMany()
                        .HasForeignKey("DirectorTecnicoPersonaId");

                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("DirectorTecnico");

                    b.Navigation("municipio");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoFutbolDepartamental.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Arbitro", "Arbitro")
                        .WithMany()
                        .HasForeignKey("ArbitroPersonaId");

                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Equipo", "EquipoLocal")
                        .WithMany()
                        .HasForeignKey("EquipoLocalEquipoId");

                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Equipo", "EquipoVisitante")
                        .WithMany()
                        .HasForeignKey("EquipoVisitanteEquipoId");

                    b.HasOne("TorneoFutbolDepartamental.App.Dominio.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId");

                    b.Navigation("Arbitro");

                    b.Navigation("EquipoLocal");

                    b.Navigation("EquipoVisitante");

                    b.Navigation("Estadio");
                });
#pragma warning restore 612, 618
        }
    }
}