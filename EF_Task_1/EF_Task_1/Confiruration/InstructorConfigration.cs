
using EF_Task_1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Configuration
{
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(i => i.Department)
                    .WithMany(d => d.Instructors)
                    .HasForeignKey(i => i.Dept_ID)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
