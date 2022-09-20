using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCrudBackEndNetCore.Domain.Entities;

namespace SimpleCrudBackEndNetCore.Infra.EntityMappers
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)  
        {
            builder.ToTable("Person", "dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(100).IsRequired(); 

            builder.Ignore(x => x.ValidationResult);

            builder.OwnsOne(
               x => x.Address,
               b =>
               {
                   b.Property(o => o.Nationality).HasColumnName("Nationality").HasMaxLength(100).IsRequired();
                   b.Property(o => o.ZoneInformationPostalCode).HasColumnName("ZoneInformationPostalCode").HasMaxLength(100).IsRequired();
                   b.Property(o => o.City).HasColumnName("City").HasMaxLength(100).IsRequired();
                   b.Property(o => o.PublicPlace).HasColumnName("PublicPlace").HasMaxLength(100).IsRequired();
                   b.Property(o => o.BrazilianUfId).HasColumnName("BrazilianUfId").IsRequired();
                   b.HasOne(o => o.BrazilianUf).WithMany().HasForeignKey(o => o.BrazilianUfId);
               });
        }
    }
}
