
namespace Payroll.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Payroll.Models.Entities;
    using Payroll.Models;
    

    public interface IGenericRepository<T> where T : BaseClass
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(Guid id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(Guid id);
    }
}
