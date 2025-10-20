using MVC_Sec_Project.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Configurations
{
    public class BaseEntityConfigurations<T>:IEntityTypeConfiguration<T> where T : BaseEntity
    {
      

        public  void Configure(EntityTypeBuilder<T> builder)
        {
            

            //every time a new record is created, this column will be populated with the current date and time
            builder.Property(d => d.CreatedOn).HasDefaultValueSql("getdate()");
            //Every time the record is updated, this column will be updated with the current date and time
            builder.Property(d => d.LastModifiedOn).HasComputedColumnSql("getdate()");
        }
    }
}
