using AutopartsEntity.ExtensionForUsers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutopartsRepository.Configurations.ExtensionForUsers
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired()
                .HasMaxLength(10);
            builder.Property(x => x.UpdateDate)
                .HasMaxLength(10);
            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.Property(x => x.NumericCountryCode).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.ISOAlpha2).IsRequired()
                .HasMaxLength(2);
            builder.Property(x => x.ISOAlpha3).IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.CountryNameCZ).IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.CountryNameENG).IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.IsActive)
                .HasDefaultValue(false);
            builder.Property(x => x.CurrencyId).IsRequired();

            builder.HasData(
                new Country { Id = 1, NumericCountryCode = 203, ISOAlpha2 = "CZ", ISOAlpha3 = "CZE", CountryNameCZ = "Česká republika", CountryNameENG = "Czech Republic", CurrencyId = 1, IsActive = true },
                new Country { Id = 2, NumericCountryCode = 703, ISOAlpha2 = "SK", ISOAlpha3 = "SVK", CountryNameCZ = "Slovenská republika", CountryNameENG = "Slovakia", CurrencyId = 2, IsActive = true },
                new Country { Id = 3, NumericCountryCode = 616, ISOAlpha2 = "PL", ISOAlpha3 = "POL", CountryNameCZ = "Polsko", CountryNameENG = "Poland", CurrencyId = 3, IsActive = true },
                new Country { Id = 4, NumericCountryCode = 276, ISOAlpha2 = "DE", ISOAlpha3 = "DEU", CountryNameCZ = "Německo", CountryNameENG = "Germany", CurrencyId = 2, IsActive = true },
                new Country { Id = 5, NumericCountryCode = 040, ISOAlpha2 = "AT", ISOAlpha3 = "AUT", CountryNameCZ = "Rakousko", CountryNameENG = "Austria", CurrencyId = 2, IsActive = true }
                );
        }
    }
}