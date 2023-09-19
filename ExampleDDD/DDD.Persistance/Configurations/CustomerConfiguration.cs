using DDD.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Persistance.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasConversion(customerId => customerId.Value,value =>new CustomerId(value));

        builder.Property(c => c.Name).HasMaxLength(20);
        builder.Property(c => c.Email).HasMaxLength(30);
        builder.HasIndex(c=> c.Email).IsUnique();

    }
}
