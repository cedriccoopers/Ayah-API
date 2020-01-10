using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Repositories
{
    public interface IEmployee : IRepositories<Employee>
    {
        Task<IEnumerable<Employee>> GetAllWithEmployeeAsync();
        //Task<Employee> GetWithEmployeeByIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllWithGenderByGenderIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllWithTownByTownIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllWithNationalityByNationalityIdAsync(int id);
    }
    
}
