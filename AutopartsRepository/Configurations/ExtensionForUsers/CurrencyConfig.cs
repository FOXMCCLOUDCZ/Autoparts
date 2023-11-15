using AutopartsEntity.ExtensionForUsers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.ExtensionForUsers
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.NumericCurrencyCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CurrencyCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CurrencyName).IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);

            builder.HasData(
                new Currency { Id = 1, NumericCurrencyCode = 203, CurrencyCode = "CZK", CurrencyName = "Česká koruna", IsActive = true },
                new Currency { Id = 2, NumericCurrencyCode = 978, CurrencyCode = "EUR", CurrencyName = "Euro", IsActive = true },
                new Currency { Id = 3, NumericCurrencyCode = 985, CurrencyCode = "PLN", CurrencyName = "Złoty", IsActive = true }
                );
        }
    }
}