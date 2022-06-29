using ShowHouse.Application.DTO;

namespace ShowHouse.Application.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetEvents();
        Task<EventDTO> GetById(int? id);
        Task Add(EventDTO eventDTO);
        Task Update(EventDTO eventDTO);
        Task Remove(int? id);
    }
}