using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Table_Per_Hierarchy.Models
{
    internal class InfoDbContext : DbContext
    {


        public DbSet<Doctor>? Doctors { get; set; }

        public DbSet<Nurse>? Nurses { get; set; }

        public DbSet<Driver>? Drivers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial catalog=TablePerHierarchy;Integrated Security=SSPI;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var doctors = new Doctor[]
            {
                new Doctor()
                {
                    Id=1,
                    Name="Doctor-1",
                    Salary = 100,
                    Education="mbbs",
                    MaxPatients=15
                }  ,              
                
                new Doctor()
                {
                    Id=2,
                    Name="Doctor-2",
                    Salary = 200,
                    Education="mbbs",
                    MaxPatients=25
                }
            };


            var Nurses = new Nurse[]
            {
                new Nurse()
                {
                    Id=3,
                    Name="Nurse-1",
                    Salary = 100,
                    Experience=5,
                    ExtraHours=15
                }  ,

                new Nurse()
                {
                    Id=4,
                    Name="Nurse-2",
                    Salary = 200,
                    Experience=4,
                    ExtraHours=25
                }
            };

            var Drivers = new Driver[]
            {
                new Driver()
                {
                    Id=5,
                    Name="Driver-1",
                    Salary = 100,
                    VehicleType="car",
                    Bonus =50
                }  ,

                new Driver()
                {
                    Id=6,
                    Name="Driver-2",
                    Salary = 200,
                    VehicleType="truck",
                    Bonus=25
                }
            };


            base.OnModelCreating(modelBuilder);
        }
    }
}
