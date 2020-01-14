using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayah.Core.Models;
using Ayah.Core.Repositories;

namespace Ayah.Data.Repositories
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(AyahDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Gender>> GetAllAsync()
        {
            return await AyahDbContext.Gender
                .Include(m => m.Gender)
                .ToListAsync();
        }

        public async Task<Gender> GetWithGenderByIdAsync(int id)
        {
            return await AyahDbContext.Gender
                .Include(m => m.Gender)
                .SingleOrDefaultAsync(m => m.Id == id); ;
        }

        private AyahDbContext AyahDbContext
        {
            get { return Context as AyahDbContext; }
        }
    }
}