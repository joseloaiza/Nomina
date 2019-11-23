
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

    
    public class EmployeeService : IEmployeeService 
    {
       // private readonly IEmployeeRepository iEmployeeRepositor;
        //private readonly IGenericRepository<Employee> _employeeRepository;
      // private readonly IEmployeeRepository _employeeRepository;
       private readonly IUnitOfWork _UOW;


        //public EmployeeService(IGenericRepository<Employee> employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;           
        //}

        //public EmployeeService(IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}

        public EmployeeService(IUnitOfWork uow)
        {
            _UOW = uow;
        }
        

        public async Task CreateAsync(Country entity)
        {
            var repo = _UOW.GetRepositoryAsync<Country>();
            // var r = _UOW.GetRepository<Employee>();
            await repo.AddAsync(entity);
            _UOW.SaveChanges();
            //return  _employeeRepository.GetAll();
            // await _employeeRepository.CreateAsync(entity);           
        }

        public async Task DeleteAsync(Guid id)
        //public void DeleteAsync(Country entity)
        {
            var repo = _UOW.GetRepository<Country>();
            repo.Delete(id);
            _UOW.SaveChanges();
            
            // return _employeeRepository.DeleteAsync(entity);
        }

        public Task<bool> ExistAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Country> GetAll()
        {
           var repo = _UOW.GetReadOnlyRepository<Country>();
            // var r = _UOW.GetRepository<Employee>();
            return repo.GetList().Items.AsQueryable(); 
            //return  _employeeRepository.GetAll();
        }

        public Country GetByIdAsync(Guid id)
        {
            var repo = _UOW.GetReadOnlyRepository<Country>();
            return repo.Search(id);
            
           // throw new NotImplementedException();
            //return _employeeRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Country entity)
        {
            var repo = _UOW.GetRepositoryAsync<Country>();
            // var r = _UOW.GetRepository<Employee>();
            repo.UpdateAsync(entity);
            _UOW.SaveChanges();

        }
    }
}
