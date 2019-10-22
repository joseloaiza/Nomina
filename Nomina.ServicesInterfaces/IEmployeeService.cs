

namespace Nomina.ServicesInterfaces
{
    using Nomina.Core.DomainEntities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Text;
    public  interface IEmployeeService
    {
        IQueryable<Employee> GetAll();

        Task<Employee> GetByIdAsync(int id);

        Task CreateAsync(Employee entity);

        Task UpdateAsync(Employee entity);

        Task DeleteAsync(Employee entity);

        Task<bool> ExistAsync(int id);
    }
}
