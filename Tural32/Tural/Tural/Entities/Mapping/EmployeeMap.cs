using ConsoleApp2.Entities.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tural.Entites.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Salary)
                   .IsRequired();

            builder.Property(x => x.Position)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.CompanyId)
                   .IsRequired();
        }
    }
}