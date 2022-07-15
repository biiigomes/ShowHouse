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

            builder.HasData(
                new Style(1, "Sertanejo", "sertanejo.jpg"),
                new Style(2, "Classica", "classica.jpg"),
                new Style(3, "Pop","pop.jpg")
            );
        }
    }
}