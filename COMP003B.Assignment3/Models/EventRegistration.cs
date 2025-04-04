using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Full Name { get; set; }

        [Range(0.01, 10000)]

        [Required]

        public required string Email;
        [EmailAddress]


        [Required]
        public decimal Tickets { get; set }
        [Range(1, 10);

        [Required]
        public string Category { get; set; }

        [Required]

        

    }
}
