using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Data.Context.EntitiesConfiguration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Capacity).IsRequired();
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.TicketValue).HasPrecision(10, 2);
            builder.Property(p => p.Status).IsRequired();

            builder.HasOne(e => e.ShowHouse).WithMany(e => e.Events).HasForeignKey(e => e.ShowHouseId);
            builder.HasOne(e => e.Style).WithMany(e => e.Events).HasForeignKey(e => e.StyleId);

        }
    }
}