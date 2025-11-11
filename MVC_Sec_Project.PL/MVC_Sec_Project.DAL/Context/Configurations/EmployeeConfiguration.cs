using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVC_Sec_Project.DAL.Context.Configurations;
internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.Name)
            .HasColumnType("VarChar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(e => e.Image)
           .HasColumnType("VarChar")
           .HasMaxLength(256)
            .IsRequired(false);


        builder.Property(e => e.Email)
            .HasColumnType("VarChar")
            .HasMaxLength(30)
            .IsRequired(false);

        builder.Property(e => e.PhoneNumber)
            .HasColumnType("Char")
            .HasMaxLength(11)
            .IsRequired(false);

        builder.Property(e => e.Salary)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(e => e.Gender)
            .HasConversion(x => x.ToString(),
            s => Enum.Parse<Gender>(s));


        builder.Property(e => e.EmployeeType)
            .HasConversion<string>();

        builder.HasOne(e => e.Department)
            .WithMany(e => e.Employees)
            .HasForeignKey(e => e.DepartmentId);

    }
}
