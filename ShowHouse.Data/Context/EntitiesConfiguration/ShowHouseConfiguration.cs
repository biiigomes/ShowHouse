using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Data.Context.EntitiesConfiguration
{
    public class ShowHouseConfiguration : IEntityTypeConfiguration<ShowHouseEvent>
    {
        public void Configure(EntityTypeBuilder<ShowHouseEvent> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            builder.HasData(
                new ShowHouseEvent(1, "Clássica","São Paulo - Alphaville", true),
                new ShowHouseEvent(2, "Rock", "São Paulo - Limoeiro", true),
                new ShowHouseEvent(3, "Pop", "Curitiba - Água Verde", true)
            );
        }
    }
}