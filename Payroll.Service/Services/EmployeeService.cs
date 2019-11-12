
namespace Payroll.Domain.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Payroll.Models.Entities;
    using Payroll.Domain.Interfaces;
    using Payroll.Infrastructure; 
    using Threenine.Data;
    
    public class EmployeeService : IEmployeeService 
    {
       // private readonly IEmployeeRepository iEmployeeRepositor;
        //private readonly IGenericRepository<Employee> _employeeRepository;
       private readonly IEmployeeRepository _employeeRepository;
       private readonly IUnitOfWork _UOW;


        //public EmployeeService(IGenericRepository<Employee> employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;           
        //}

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public EmployeeService(IUnitOfWork uow)
        {
            _UOW = uow;
        }



        public async Task CreateAsync(Employee entity)
        {
          await _employeeRepository.CreateAsync(entity);           
        }

        public Task DeleteAsync(Employee entity)
        {
           return _employeeRepository.DeleteAsync(entity);
        }

        public Task<bool> ExistAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetAll()
        {
           // var repo = _UOW.GetReadOnlyRepository<Employee>();
           // var r = _UOW.GetRepository<Employee>();


            //return repo.GetList<Employee>(null,null,null,null,0,20,true).Items.AsQueryable<Employee>;
            return  _employeeRepository.GetAll();
        }

        public Task<Employee> GetByIdAsync(Guid id)
        {
            return _employeeRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Employee entity)
        {
            await _employeeRepository.UpdateAsync(entity);
        }
    }
}
