﻿// <auto-generated />
using System;
using Linkedin.RegistroProfesionales.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Linkedin.RegistroProfesionales.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230704055623_cambiosTablaCurso")]
    partial class cambiosTablaCurso
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funciones")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Profesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Genero")
                        .HasColumnType("bit");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Profesionales");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.ProfesionalCurso", b =>
                {
                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasKey("ProfesionalId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("ProfesionalesCursos");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Experiencia", b =>
                {
                    b.HasOne("Linkedin.RegistroProfesionales.Entity.Profesional", "Profesional")
                        .WithMany("Experiencias")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profesional");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.ProfesionalCurso", b =>
                {
                    b.HasOne("Linkedin.RegistroProfesionales.Entity.Curso", "Curso")
                        .WithMany("ProfesionalCurso")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Linkedin.RegistroProfesionales.Entity.Profesional", "Profesional")
                        .WithMany("ProfesionalCurso")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Profesional");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Curso", b =>
                {
                    b.Navigation("ProfesionalCurso");
                });

            modelBuilder.Entity("Linkedin.RegistroProfesionales.Entity.Profesional", b =>
                {
                    b.Navigation("Experiencias");

                    b.Navigation("ProfesionalCurso");
                });
#pragma warning restore 612, 618
        }
    }
}
