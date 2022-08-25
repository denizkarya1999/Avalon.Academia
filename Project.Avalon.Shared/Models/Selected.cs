using System.ComponentModel.DataAnnotations;

namespace Project.Avalon.Shared.Models
{
    public class Selected
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string University { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //Those values can be either null or 0
        public string? ReferralNotes { get; set; }
    }
}
