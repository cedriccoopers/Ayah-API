using System.Collections.Generic;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Services
{
    public interface IGender
    {
        Task<Gender> GetGenderById(int id);
        Task<IEnumerable<Gender>> GetAllGender();
    }
}