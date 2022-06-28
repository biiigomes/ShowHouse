using MVChallenge.ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Interfaces
{
    public interface IShowHouseEventRepository
    {
        Task<IEnumerable<ShowHouseEvent>> GetShowHousesAsync();
        Task<ShowHouseEvent> GetByIdAsync(int? id);
        Task<ShowHouseEvent> CreateAsync(ShowHouseEvent showHouse);
        Task<ShowHouseEvent> UpdateAsync(ShowHouseEvent showHouse);
        Task<ShowHouseEvent> RemoveAsync(ShowHouseEvent showHouse);
    }
}