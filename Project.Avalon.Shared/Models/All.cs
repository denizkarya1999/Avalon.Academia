using System.ComponentModel.DataAnnotations;

namespace Project.Avalon.Shared.Models
{
    public class All
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string AdmitTerm { get; set; }
        public string College { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        //Neither required nor should be null
        public bool IsSelectedForReferral { get; set; }
        public bool IsInCurrentTerm { get; set; }

        //Those values can be either null or 0
        public string? Concentration { get; set; }
        public int CreditsCompleted { get; set; }
        public double GPA { get; set; }
        public DateTime? GraduationDate { get; set; }
        public bool? HasGoodAcademicStanding { get; set; }
        public string? Minor { get; set; }
    }
}
