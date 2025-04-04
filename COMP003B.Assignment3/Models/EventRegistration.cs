using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
           

            public int Id { get; set; }

            [Required]
            [MinLength(3)]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            public string EmailAddress { get; set; }

            [Required]
            [MaxLength(20)]
            public string EventCode { get; set; }


            [Required]
            [Range(1, 10)]
            public string Tickets{ get; set; }

          
            public string ReferralCode { get; set; }



        }
    }
