using System;
using System.ComponentModel.DataAnnotations;

namespace FakeHealthcareApp.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string SocialSecurityNumber { get; set; }

        [Required]
        public string MedicalUniversity { get; set; }
    }
}
