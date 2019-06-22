

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
        IQueryable<Employees> GetAll();

        Task<Employees> GetByIdAsync(int id);

        Task CreateAsync(Employees entity);

        Task UpdateAsync(Employees entity);

        Task DeleteAsync(Employees entity);

        Task<bool> ExistAsync(int id);
    }
}
