using ShowHouse.Application.DTO;

namespace ShowHouse.Application.Interfaces
{
    public interface IShowHouseEventService
    {
         Task<IEnumerable<ShowHouseEventDTO>> GetShowHouses();
         Task<ShowHouseEventDTO> GetById(int? id);
         Task Add(ShowHouseEventDTO showHouseEventDTO);
         Task Update(ShowHouseEventDTO showHouseEventDTO);
         Task Remove(int? id);
    }
}