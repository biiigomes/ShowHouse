using ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Interfaces
{
    public interface IStyleRepository
    {
        Task<IEnumerable<Style>> GetStyles();
        Task<Style> GetById(int? id);
    }
}