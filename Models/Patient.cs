using System;
using System.ComponentModel.DataAnnotations;

namespace FakeHealthcareApp.Models
{
public class Patient
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string TelephoneNumber { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string SocialSecurityNumber { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public string Allergies { get; set; }

    [Required]
    public decimal CurrentChargesOwed { get; set; }
}
}