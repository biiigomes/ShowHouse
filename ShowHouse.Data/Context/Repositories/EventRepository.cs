using Microsoft.EntityFrameworkCore;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Data.Context.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _eventContext;

        public EventRepository(ApplicationDbContext context)
        {
            _eventContext = context;
        }
 
        public async Task<Event> CreateAsync(Event events)
        {
            _eventContext.Add(events);
            await _eventContext.SaveChangesAsync();
            return events;
        }

        public async Task<Event> GetByIdAsync(int? id)
        {
            return await _eventContext.Events.FindAsync(id);
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            return await _eventContext.Events
               .Include(s => s.ShowHouse).Include(s => s.Style)
                  .ToListAsync();
        }

        public async Task<Event> RemoveAsync(Event events)
        {
            _eventContext.Remove(events);
            await _eventContext.SaveChangesAsync();
            return events;
        }

        public async Task<Event> UpdateAsync(Event events)
        {
            _eventContext.Update(events);
            await _eventContext.SaveChangesAsync();
            return events;
        }
    }
}