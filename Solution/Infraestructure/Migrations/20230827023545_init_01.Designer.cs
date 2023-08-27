﻿// <auto-generated />
using System;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230827023545_init_01")]
    partial class init_01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Acceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Accesos");
                });

            modelBuilder.Entity("Domain.Entities.AreaDeportiva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeporteEspecificoid")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("IndLocalizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PolideportivoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeporteEspecificoid")
                        .IsUnique()
                        .HasFilter("[DeporteEspecificoid] IS NOT NULL");

                    b.HasIndex("PolideportivoId");

                    b.ToTable("AreasDeportivas");
                });

            modelBuilder.Entity("Domain.Entities.ComplejoDeportivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Localizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeOlimpicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SedeOlimpicaId");

                    b.ToTable("ComplejosDeportivos");
                });

            modelBuilder.Entity("Domain.Entities.Deporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaDeportivaId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaDeportivaId")
                        .IsUnique();

                    b.ToTable("Deportes");
                });

            modelBuilder.Entity("Domain.Entities.DeporteEspecifico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Capacidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComplejoDeportivoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoDeportivoId");

                    b.ToTable("Especificos");
                });

            modelBuilder.Entity("Domain.Entities.Equipamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Equipamientos");
                });

            modelBuilder.Entity("Domain.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComplejoDeportivoId")
                        .HasColumnType("int");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroComisarios")
                        .HasColumnType("int");

                    b.Property<int>("NroParticipantes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoDeportivoId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Domain.Entities.Polideportivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<int>("ComplejoDeportivoId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinAtencion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InicioAtencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoDeportivoId");

                    b.ToTable("Polideportivos");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Domain.Entities.SedeOlimpica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroComplejos")
                        .HasColumnType("int");

                    b.Property<decimal>("Presupuesto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SedesOlimpicas");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComplejoDeportivoId")
                        .HasColumnType("int");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComplejoDeportivoId")
                        .IsUnique()
                        .HasFilter("[ComplejoDeportivoId] IS NOT NULL");

                    b.HasIndex("EventoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.Acceso", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "UsuarioAsoc")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioAsoc");
                });

            modelBuilder.Entity("Domain.Entities.AreaDeportiva", b =>
                {
                    b.HasOne("Domain.Entities.DeporteEspecifico", "DeporteEspecifico")
                        .WithOne("AreaDeportiva")
                        .HasForeignKey("Domain.Entities.AreaDeportiva", "DeporteEspecificoid");

                    b.HasOne("Domain.Entities.Polideportivo", "Polideportivo")
                        .WithMany()
                        .HasForeignKey("PolideportivoId");

                    b.Navigation("DeporteEspecifico");

                    b.Navigation("Polideportivo");
                });

            modelBuilder.Entity("Domain.Entities.ComplejoDeportivo", b =>
                {
                    b.HasOne("Domain.Entities.SedeOlimpica", "SedeOlimpica")
                        .WithMany()
                        .HasForeignKey("SedeOlimpicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SedeOlimpica");
                });

            modelBuilder.Entity("Domain.Entities.Deporte", b =>
                {
                    b.HasOne("Domain.Entities.AreaDeportiva", "AreaDeportiva")
                        .WithOne("Deporte")
                        .HasForeignKey("Domain.Entities.Deporte", "AreaDeportivaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AreaDeportiva");
                });

            modelBuilder.Entity("Domain.Entities.DeporteEspecifico", b =>
                {
                    b.HasOne("Domain.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithMany()
                        .HasForeignKey("ComplejoDeportivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");
                });

            modelBuilder.Entity("Domain.Entities.Equipamiento", b =>
                {
                    b.HasOne("Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Domain.Entities.Evento", b =>
                {
                    b.HasOne("Domain.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithMany()
                        .HasForeignKey("ComplejoDeportivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");
                });

            modelBuilder.Entity("Domain.Entities.Polideportivo", b =>
                {
                    b.HasOne("Domain.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithMany()
                        .HasForeignKey("ComplejoDeportivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.ComplejoDeportivo", "ComplejoDeportivo")
                        .WithOne("Usuario")
                        .HasForeignKey("Domain.Entities.Usuario", "ComplejoDeportivoId");

                    b.HasOne("Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplejoDeportivo");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Domain.Entities.AreaDeportiva", b =>
                {
                    b.Navigation("Deporte");
                });

            modelBuilder.Entity("Domain.Entities.ComplejoDeportivo", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.DeporteEspecifico", b =>
                {
                    b.Navigation("AreaDeportiva");
                });
#pragma warning restore 612, 618
        }
    }
}
