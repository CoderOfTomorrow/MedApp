using MedApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MedApp;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}