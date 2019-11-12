

namespace Payroll.ServicesInterface
{
    using Payroll.Entities.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Text;
    public  interface IEmployeeService
    {
        IQueryable<Employee> GetAll();

        Task<Employee> GetByIdAsync(Guid id);

        Task CreateAsync(Employee entity);

        Task UpdateAsync(Employee entity);

        Task DeleteAsync(Employee entity);

        Task<bool> ExistAsync(Guid id);
    }
}
