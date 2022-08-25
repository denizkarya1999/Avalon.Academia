using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Avalon.Web.Migrations
{
    public partial class AllCurrentSelectedandStudentsDBContextCreatedwithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllStudents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdmitTerm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSelectedForReferral = table.Column<bool>(type: "bit", nullable: false),
                    IsInCurrentTerm = table.Column<bool>(type: "bit", nullable: false),
                    Concentration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditsCompleted = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HasGoodAcademicStanding = table.Column<bool>(type: "bit", nullable: true),
                    Minor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentStudents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSelectedForReferral = table.Column<bool>(type: "bit", nullable: false),
                    Concentration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    HasNoComplains = table.Column<bool>(type: "bit", nullable: true),
                    Minor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectedStudents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferralNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedStudents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AllStudents",
                columns: new[] { "Id", "AdmitTerm", "College", "Concentration", "CreditsCompleted", "Department", "Email", "GPA", "GraduationDate", "HasGoodAcademicStanding", "IsInCurrentTerm", "IsSelectedForReferral", "Major", "Minor", "Name", "University" },
                values: new object[] { "9102 4795", "Winter 2021", "College of Engineering & Computer Science", "Game Design", 60, "Computer and Information Science Department", "dacikbas@umich.edu", 3.0, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, "Computer and Information Science", null, "Deniz Acikbas", "University of Michigan-Dearborn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllStudents");

            migrationBuilder.DropTable(
                name: "CurrentStudents");

            migrationBuilder.DropTable(
                name: "SelectedStudents");
        }
    }
}
