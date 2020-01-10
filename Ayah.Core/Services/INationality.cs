using System.Collections.Generic;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Services
{
    public interface INationality
    {
        Task<Nationality> GetNationalityById(int id);
        Task<IEnumerable<Nationality>> GetAllNationality();
    }
}