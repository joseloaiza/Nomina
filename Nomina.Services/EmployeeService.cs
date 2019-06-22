

namespace Nomina.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Nomina.Core.DomainEntities;
    using Nomina.Core.RepositoriesInterfaces;
    using Nomina.ServicesInterfaces;
    public class EmployeeService : IEmployeeService
    {
       // private readonly IEmployeeRepository iEmployeeRepositor;
        private readonly IGenericRepository<Employees> _employeeRepository;

        public EmployeeService(IGenericRepository<Employees> employeeRepository)
        {
            _employeeRepository = employeeRepository;           
        }
        

        public async Task CreateAsync(Employees entity)
        {
          await _employeeRepository.CreateAsync(entity);           
        }

        public Task DeleteAsync(Employees entity)
        {
           return _employeeRepository.DeleteAsync(entity);
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employees> GetAll()
        {
            return  _employeeRepository.GetAll();
        }

        public Task<Employees> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Employees entity)
        {
            await _employeeRepository.UpdateAsync(entity);
        }
    }
}
