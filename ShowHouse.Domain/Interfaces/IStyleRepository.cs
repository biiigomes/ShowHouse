using MVChallenge.ShowHouse.Domain.Entities;

namespace ShowHouse.Domain.Interfaces
{
    public interface IStyleRepository
    {
        Task<IEnumerable<Style>> GetStylesAsync();
        Task<Style> GetByIdAsync(int? id);
    }
}