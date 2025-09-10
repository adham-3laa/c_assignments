using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Task_1.Confiruration
{
    internal class Course_InstConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Context.Course_Inst>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Context.Course_Inst> builder)
        {
            builder.ToTable("Course_Inst");
            builder.HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
    }
    
    
}
