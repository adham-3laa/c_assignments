using TPCT_TPH_TPT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCT_TPH_TPT.Contexts
{
    public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=.;database=TestG02DB;Trusted_Connection = true;trustServerCertificate=true");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FullTimeEmployee>()
            //            .HasBaseType<Employee>();

            //modelBuilder.Entity<PartTimeEmployee>()
            //           .HasBaseType<Employee>();

            //modelBuilder.Entity<Employee>()
            //            .HasDiscriminator<string>("EmployeeType")
            //            .HasValue<FullTimeEmployee>("FT")
            //            .HasValue<PartTimeEmployee>("PT");

            //OVERRIDE DEFAULT BEHAIVOR

            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");

        }


        public DbSet<Employee> Employees { get; set; }  
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }

        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
