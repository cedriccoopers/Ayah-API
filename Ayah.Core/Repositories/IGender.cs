using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Repositories
{
    public interface IGender:IRepositories<Gender>
    {
        Task<IEnumerable<Gender>> GetAllWithGenderAsync();
    }
}