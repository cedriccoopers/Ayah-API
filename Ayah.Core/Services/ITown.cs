using System.Collections.Generic;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Services
{
    public interface ITown
    {
        Task<Town> GetTownById(int id);
        Task<IEnumerable<Town>> GetAllTown();
    }
}