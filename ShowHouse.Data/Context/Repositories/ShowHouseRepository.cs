using Microsoft.EntityFrameworkCore;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Data.Context.Repositories
{
    public class ShowHouseRepository : IShowHouseEventRepository
    {
        ApplicationDbContext _showHouseContext;
        public ShowHouseRepository(ApplicationDbContext context)
        {
            _showHouseContext = context;
        }

        public async Task<ShowHouseEvent> Create(ShowHouseEvent showHouse)
        {
            _showHouseContext.Add(showHouse);
            await _showHouseContext.SaveChangesAsync();
            return showHouse;
        }

        public async Task<ShowHouseEvent> GetById(int? id)
        {
            return await _showHouseContext.ShowHouseEvents.FindAsync(id);
        }

        public async Task<IEnumerable<ShowHouseEvent>> GetShowHouses()
        {
            return await _showHouseContext.ShowHouseEvents.ToListAsync();
        }

        public async Task<ShowHouseEvent> Remove(ShowHouseEvent showHouse)
        {
            _showHouseContext.Remove(showHouse);
            await _showHouseContext.SaveChangesAsync();
            return showHouse;
        }

        public async Task<ShowHouseEvent> Update(ShowHouseEvent showHouse)
        {
            _showHouseContext.Update(showHouse);
            await _showHouseContext.SaveChangesAsync();
            return showHouse;
        }
    }
}