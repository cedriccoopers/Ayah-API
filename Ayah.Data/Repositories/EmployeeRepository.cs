using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayah.Core.Models;
using Ayah.Core.Repositories;

namespace Ayah.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AyahDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Gender>> GetAllWithGenderAsync()
        {
            return await AyahDbContext.Gender
                .Include(m => m.Gender)
                .ToListAsync();
        }

        public async Task<Employee> GetWithTownByIdAsync(int id)
        {
            return await AyahDbContext.Musics
                .Include(m => m.Artist)
                .SingleOrDefaultAsync(m => m.Id == id); ;
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await AyahDbContext.Musics
                .Include(m => m.Artist)
                .Where(m => m.ArtistId == artistId)
                .ToListAsync();
        }

        private AyahDbContext AyahDbContext
        {
            get { return Context as AyahDbContext; }
        }
    }
}