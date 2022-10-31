using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_First_Approach.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_First.Models
{
    internal class InfoDbContext : DbContext
    {
        public InfoDbContext()
        {

        }

        public DbSet<Person> people { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PLONDHE-LAP-072\\MSSQLSERVER01;Initial catalog=CodiCodeFirst1;Integrated Security=SSPI;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                        .HasOne<Department>(e => e.Dept)
                        .WithMany(d => d.Employees)
                        .HasForeignKey(e => e.DeptNo);


            modelBuilder.Entity<Department>().HasKey(d => d.DeptNo);
            modelBuilder.Entity<Department>().Property(d => d.DeptName).IsRequired();
            modelBuilder.Entity<Department>().Property(d => d.Capacity).IsRequired();

            modelBuilder.Entity<Employee>().HasKey(e => e.EmpNo);
            modelBuilder.Entity<Employee>().Property(e => e.EmpName).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.DeptNo).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Age).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
