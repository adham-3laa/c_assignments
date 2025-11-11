using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVC_Sec_Project.DAL.Context.Configurations;
internal class DepartmentConfigurations
    : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(x => x.Id)
            .UseIdentityColumn(10, 10);


        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("varChar")
            .HasMaxLength(50);

        builder.Property(x => x.Code)
             .IsRequired()
             .HasColumnType("varChar")
             .HasMaxLength(50);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasColumnType("varChar")
            .HasMaxLength(50);

        builder.Property(x => x.CreatedOn)
            .HasDefaultValueSql("GETDATE()");
    }
}
