using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PunchClock.Database.Domain
{


    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.Property(e=>e.VehicleNumber).IsRequired().HasMaxLength(100);
        }

    }
}
