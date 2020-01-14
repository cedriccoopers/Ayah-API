using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayah.Core.Models;
using Ayah.Core.Repositories;

namespace Ayah.Data.Repositories
{
    public class NationalityRepository : Repository<Nationality>, INationalityRepository
    {
        public NationalityRepository(AyahDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Nationality>> GetAllAsync()
        {
            return await AyahDbContext.Nationality
                .Include(m => m.Nationality)
                .ToListAsync();
        }

        public async Task<Nationality> GetWithGenderByIdAsync(int id)
        {
            return await AyahDbContext.Nationality
                .Include(m => m.Town)
                .SingleOrDefaultAsync(m => m.Id == id); ;
        }

        private AyahDbContext AyahDbContext
        {
            get { return Context as AyahDbContext; }
        }
    }
}