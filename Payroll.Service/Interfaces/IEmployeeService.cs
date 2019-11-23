

namespace Payroll.Domain.Interfaces
{
    using Payroll.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Text;
    public  interface IEmployeeService
    {
        IQueryable<Country> GetAll();

        Country GetByIdAsync(Guid id);

        Task CreateAsync(Country entity);

        Task UpdateAsync(Country entity);

        //void DeleteAsync(Country entity);
        Task DeleteAsync(Guid id);

        Task<bool> ExistAsync(Guid id);
    }
}
