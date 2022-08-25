using System.ComponentModel.DataAnnotations;

namespace Project.Avalon.Shared.Models
{
    public class Current
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string College { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //Neither required nor should be null
        public bool IsSelectedForReferral { get; set; }

        //Those values can be either null or 0
        public string? Concentration { get; set; }
        public double GPA { get; set; }
        public bool? HasNoComplains { get; set; }
        public string? Minor { get; set; }
        public string? Notes { get; set; }
    }
}
