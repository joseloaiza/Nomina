﻿

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

        Task<Employee> GetByIdAsync(Guid id);

        Task CreateAsync(Employee entity);

        Task UpdateAsync(Employee entity);

        Task DeleteAsync(Employee entity);

        Task<bool> ExistAsync(Guid id);
    }
}
