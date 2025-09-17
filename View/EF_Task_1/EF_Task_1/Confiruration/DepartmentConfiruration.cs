using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Task_1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_1.Confiruration
{
    internal class DepartmentConfiruration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Context.Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(d => d.ID);
            builder.Property(d => d.ID).HasColumnName("Dept_ID");
            builder.Property(d => d.Name).HasColumnName("Dept_Name").IsRequired().HasMaxLength(50);
            builder.Property(d => d.HiringDate).HasColumnName("Hiring_Date").HasColumnType("date");
            builder.HasOne(d => d.Manager)
                   .WithMany()
                   .HasForeignKey(d => d.inst_ID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
