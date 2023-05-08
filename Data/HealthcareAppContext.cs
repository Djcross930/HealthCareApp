using Microsoft.EntityFrameworkCore;
using FakeHealthcareApp.Models;

namespace FakeHealthcareApp.Data{
public class HealthcareAppContext : DbContext
{
    public HealthcareAppContext(DbContextOptions<HealthcareAppContext> options) : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
}
}