using MVC_Sec_Project.DAL.Models.Employee;
using MVC_Sec_Project.DAL.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Configurations
{
    public class EmployeeConfigurations : BaseEntityConfigurations<Employee>,IEntityTypeConfiguration<Employee> 
    {
        public new  void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(d => d.ID).UseIdentityColumn(1, 1);
            builder.HasKey(d => d.ID);

            builder.Property(e => e.Name).HasColumnType("varchar(50)");
            builder.Property(e => e.Address).HasColumnType("varchar(150)");
            builder.Property(e => e.Salary).HasColumnType("decimal(10,2)");
            builder.Property(e => e.Gender).HasConversion(
                (empGender)=>empGender.ToString(),(gender)=>(Gender)Enum.Parse(
                    typeof(Gender),gender));

            builder.Property(e => e.EmployeeType).HasConversion(
                (empType) => empType.ToString(), (empType) => (EmployeeType)Enum.Parse(
                    typeof(EmployeeType), empType));

            base.Configure(builder);







        }
    }
}
