using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShowHouse.Data.Context.Identity;
using ShowHouse.Domain.Entities;

namespace ShowHouse.Data.Context
{
    public class ApplicationDbContext :  IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }  
        public DbSet<ShowHouseEvent> ShowHouseEvents {get; set;}
        public DbSet<Event> Events {get; set;}
        public DbSet<Style> Styles {get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}