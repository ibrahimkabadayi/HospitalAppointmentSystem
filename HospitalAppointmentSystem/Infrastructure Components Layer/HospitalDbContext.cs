using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem
{
    internal class HospitalDbContext : DbContext
    {
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=SSPI;");
        }
    }
}
