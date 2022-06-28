using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Interfaces
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEventsAsync();
        Task<Event> GetByIdAsync(int? id);
        Task<Event> CreateAsync(Event events);
        Task<Event> UpdateAsync(Event events);
        Task<Event> RemoveAsync(Event events);
    }
}