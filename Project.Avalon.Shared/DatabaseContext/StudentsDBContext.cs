using Microsoft.EntityFrameworkCore;
using Project.Avalon.Shared.Models;

namespace Project.Avalon.Shared.DatabaseContext
{
    public class StudentsDBContext : DbContext
    {
        public StudentsDBContext(DbContextOptions<StudentsDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<All>().HasData(
                new All()
                {
                    Id = "9102 4795",
                    Name = "Deniz Acikbas",
                    Email = "dacikbas@umich.edu",
                    University = "University of Michigan-Dearborn",
                    Major = "Computer and Information Science",
                    Concentration = "Game Design",
                    College = "College of Engineering & Computer Science",
                    Department = "Computer and Information Science Department",
                    AdmitTerm = "Winter 2021",
                    GPA = 3.0,
                    CreditsCompleted = 60,
                    GraduationDate = new DateTime(2024, 12, 30),
                    HasGoodAcademicStanding = true,
                    IsInCurrentTerm = false,
                    IsSelectedForReferral = false
        }
                );
        }

        public DbSet<All> AllStudents { get; set; }
        public DbSet<Current> CurrentStudents { get; set; }
        public DbSet<Selected> SelectedStudents { get; set; }
    }
}
