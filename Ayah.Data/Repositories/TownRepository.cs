using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayah.Core.Models;
using Ayah.Core.Repositories;

namespace Ayah.Data.Repositories
{
    public class TownRepository : Repository<Town>, ITownRepository
    {
        public TownRepository(AyahDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Town>> GetAllAsync()
        {
            return await AyahDbContext.Town
                .Include(m => m.Town)
                .ToListAsync();
        }

        public async Task<Town> GetWithGenderByIdAsync(int id)
        {
            return await AyahDbContext.Musics
                .Include(m => m.Town)
                .SingleOrDefaultAsync(m => m.Id == id); ;
        }

        private AyahDbContext AyahDbContext
        {
            get { return Context as AyahDbContext; }
        }
    }
}