using System.Collections.Generic;
using System.Threading.Tasks;
using Ayah.Core.Models;

namespace Ayah.Core.Services
{
    public interface IEmployee
    {
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetAllEmployee();
    }
}