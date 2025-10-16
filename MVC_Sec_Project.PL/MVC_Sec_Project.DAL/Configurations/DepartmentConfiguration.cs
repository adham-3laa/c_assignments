global using MVC_Sec_Project.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Configurations
{
    public class DepartmentConfiguration : BaseEntityConfigurations<Department>,IEntityTypeConfiguration<Department>
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            //the id column will be an identity column starting from 10 and incrementing by 10
            builder.Property(d => d.ID).UseIdentityColumn(10, 10);
            
            builder.Property(d => d.Name).HasColumnType("nvarchar(20)");
            builder.Property(d => d.Code).HasColumnType("nvarchar(20)");
            base.Configure(builder);
        }
    }
}
