using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Interfaces
{
    public interface IShowHouseEventRepository
    {
        Task<IEnumerable<ShowHouseEvent>> GetShowHouses();
        Task<ShowHouseEvent> GetById(int? id);
        Task<ShowHouseEvent> Create(ShowHouseEvent showHouse);
        Task<ShowHouseEvent> Update(ShowHouseEvent showHouse);
        Task<ShowHouseEvent> Remove(ShowHouseEvent showHouse);
    }
}