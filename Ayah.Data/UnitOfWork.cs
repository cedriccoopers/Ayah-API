using System.Threading.Tasks;
using Ayah.Core;
using Ayah.Data.Repositories;

namespace Ayah.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AyahDbContext _context;
        private EmployeeRepository _employeeRepository;
        private GenderRepository _genderRepository;

        private TownRepository _townRepository;

        private NationalityRepository _nationalityRepository;

        public UnitOfWork(AyahDbContext context)
        {
            this._context = context;
        }

        public EmployeeRepository Employee => _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context);
        public GenderRepository Gender => _genderRepository = _genderRepository ?? new GenderRepository(_context);
        public TownRepository Town => _townRepository = _townRepository ?? new TownRepository(_context);
        public NationalityRepository Nationality => _nationalityRepository ?? new NationalityRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}