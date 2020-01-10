using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Repositories
{
    public interface ITown:IRepositories<Town>
    {
        Task<IEnumerable<Town>> GetAllWithTownAsync();
    }
}