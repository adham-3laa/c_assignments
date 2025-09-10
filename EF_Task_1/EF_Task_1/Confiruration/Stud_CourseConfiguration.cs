using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Task_1.Confiruration
{
    internal class Stud_CourseConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Context.Stud_Course>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Context.Stud_Course> builder)
        {
            builder.ToTable("Stud_Course");
            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

        }

    }
}
