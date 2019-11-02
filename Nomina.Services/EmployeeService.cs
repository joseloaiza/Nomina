

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
        //private readonly IGenericRepository<Employee> _employeeRepository;
       private readonly IEmployeeRepository _employeeRepository;        


        //public EmployeeService(IGenericRepository<Employee> employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;           
        //}

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }



        public async Task CreateAsync(Employee entity)
        {
          await _employeeRepository.CreateAsync(entity);           
        }

        public Task DeleteAsync(Employee entity)
        {
           return _employeeRepository.DeleteAsync(entity);
        }

        public Task<bool> ExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetAll()
        {
            return  _employeeRepository.GetAll();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            return _employeeRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Employee entity)
        {
            await _employeeRepository.UpdateAsync(entity);
        }
    }
}
