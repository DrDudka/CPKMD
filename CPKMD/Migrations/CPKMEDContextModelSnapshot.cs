﻿// <auto-generated />
using CPKMD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CPKMD.Migrations
{
    [DbContext(typeof(CPKMEDContext))]
    partial class CPKMEDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CPKMD.Models.EducationalProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<int>("Hours")
                        .HasColumnType("integer");

                    b.Property<int>("ProgramNameId")
                        .HasColumnType("integer");

                    b.Property<int>("ProgramNumber")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingFormId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProgramNameId");

                    b.HasIndex("TrainingFormId");

                    b.ToTable("EducationalPrograms");
                });

            modelBuilder.Entity("CPKMD.Models.ProgramName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ProgramNames");
                });

            modelBuilder.Entity("CPKMD.Models.TrainingForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TrainingForms");
                });

            modelBuilder.Entity("CPKMD.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CPKMD.Models.EducationalProgram", b =>
                {
                    b.HasOne("CPKMD.Models.ProgramName", "ProgramName")
                        .WithMany("EducationalPrograms")
                        .HasForeignKey("ProgramNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPKMD.Models.TrainingForm", "TrainingForm")
                        .WithMany("EducationalPrograms")
                        .HasForeignKey("TrainingFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramName");

                    b.Navigation("TrainingForm");
                });

            modelBuilder.Entity("CPKMD.Models.ProgramName", b =>
                {
                    b.Navigation("EducationalPrograms");
                });

            modelBuilder.Entity("CPKMD.Models.TrainingForm", b =>
                {
                    b.Navigation("EducationalPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
