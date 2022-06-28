using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Data.Context.EntitiesConfiguration
{
    public class StyleConfiguration : IEntityTypeConfiguration<Style>
    {
        public void Configure(EntityTypeBuilder<Style> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(p => p.ImagePath).IsRequired();
            builder.Property(p => p.MusicalStyle).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            builder.HasData(
                new Style(1, "sertanejo.jpg", "Sertanejo", true),
                new Style(2, "classica.jpg", "Classica", true),
                new Style(3, "pop.jpg", "Pop", true)
            );
        }
    }
}