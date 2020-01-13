using System;

namespace Ayah.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasOne(m => m.Gender)
                .HasForeignKey(m => m.Id);

            builder
                .ToTable("Employee");
        }
    }
}
