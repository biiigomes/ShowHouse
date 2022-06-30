using Microsoft.EntityFrameworkCore;
using ShowHouse.Domain.Entities;
using ShowHouse.Domain.Interfaces;

namespace ShowHouse.Data.Context.Repositories
{
    public class StyleRepository : IStyleRepository
    {
        private readonly ApplicationDbContext _styleContext;

        public StyleRepository(ApplicationDbContext context)
        {
            _styleContext = context;
        }
 
        public async Task<IEnumerable<Style>> GetStyles()
        {
            return await _styleContext.Styles
                  .ToListAsync();
        }

        public async Task<Style> GetById(int? id)
        {
            return await _styleContext.Styles.FindAsync(id);
        }
    }
}