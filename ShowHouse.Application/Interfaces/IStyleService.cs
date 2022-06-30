using ShowHouse.Application.DTO;

namespace ShowHouse.Application.Interfaces
{
    public interface IStyleService
    {
        Task<IEnumerable<StyleDTO>> GetStyles();
        Task<StyleDTO> GetById(int? id);
    }
}