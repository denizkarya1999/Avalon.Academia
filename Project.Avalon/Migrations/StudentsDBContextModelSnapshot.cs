﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Avalon.Shared.DatabaseContext;

#nullable disable

namespace Project.Avalon.Web.Migrations
{
    [DbContext(typeof(StudentsDBContext))]
    partial class StudentsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project.Avalon.Shared.Models.All", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdmitTerm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Concentration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreditsCompleted")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("HasGoodAcademicStanding")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInCurrentTerm")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelectedForReferral")
                        .HasColumnType("bit");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Minor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AllStudents");

                    b.HasData(
                        new
                        {
                            Id = "9102 4795",
                            AdmitTerm = "Winter 2021",
                            College = "College of Engineering & Computer Science",
                            Concentration = "Game Design",
                            CreditsCompleted = 60,
                            Department = "Computer and Information Science Department",
                            Email = "dacikbas@umich.edu",
                            GPA = 3.0,
                            GraduationDate = new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasGoodAcademicStanding = true,
                            IsInCurrentTerm = false,
                            IsSelectedForReferral = false,
                            Major = "Computer and Information Science",
                            Name = "Deniz Acikbas",
                            University = "University of Michigan-Dearborn"
                        });
                });

            modelBuilder.Entity("Project.Avalon.Shared.Models.Current", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("College")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Concentration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<bool?>("HasNoComplains")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelectedForReferral")
                        .HasColumnType("bit");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Minor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrentStudents");
                });

            modelBuilder.Entity("Project.Avalon.Shared.Models.Selected", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferralNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SelectedStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
