using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCrudBackEndNetCore.Domain.Entities;
using SimpleCrudBackEndNetCore.Domain.Statics;

namespace SimpleCrudBackEndNetCore.Infra.EntityMappers
{
    public class BrazilianUfMap : IEntityTypeConfiguration<BrazilianUf>
    {
        public void Configure(EntityTypeBuilder<BrazilianUf> builder)
        {
            builder.ToTable("BrazilianUf", "dbo");
            builder.HasKey(b => b.Id);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Uf).HasMaxLength(50).IsRequired();
            builder.Property(x => x.UfCode).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(50).IsRequired();

            builder.Ignore(b => b.ValidationResult);

            builder.HasData(DataArray());
        }

        private BrazilianUf[] DataArray()
        {
            return BrazilianUfStatic.GetAll.Select(x => new BrazilianUf(x.Id, x.UfCode, x.UfName, x.Uf, x.Country)).ToArray();
        }
    }
}
