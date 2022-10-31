
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Reln_betn_Employee_Dept.Models
{
    public class InfoDbContext : DbContext
    {
        public InfoDbContext()
        {

        }

        public DbSet<Relations> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=PLONDHE-LAP-072\\MSSQLSERVER01;initial catalog=EmpDeptRelation;Integrated Security=SSPI");
            base.OnConfiguring(optionsBuilder);

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasKey(d => d.DeptNo);
            modelBuilder.Entity<Department>().Property(d => d.DeptName).IsRequired();
            modelBuilder.Entity<Department>().Property(d => d.BasePrice).IsRequired();



            modelBuilder.Entity<Relations>().HasKey(e => e.EmpId);
            modelBuilder.Entity<Relations>().Property(e => e.EmpName).IsRequired();
            modelBuilder.Entity<Relations>().Property(e => e.Age).IsRequired();
            modelBuilder.Entity<Relations>().Property(e => e.salary).IsRequired();


            modelBuilder.Entity<Relations>()
                        .HasOne<Department>(d => d.Dept)
                        .WithMany(e => e.Employess)
                        .HasForeignKey(e => e.DeptNo);


            

            base.OnModelCreating(modelBuilder);

        }
    }
}
