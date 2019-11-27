

namespace Payroll.Domain.Interfaces
{
    using Payroll.Models.Entities;
    using Payroll.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Text;
    public  interface ICountryService : IDisposable
    {
        Task<Response<List<Country>>> Get();
        Task<Response<Country>> Get(Guid id);
        Task<Response<string>> Create(Country entity);
        Task<Response<string>> Update(Country entity);
        Task<Response<string>> Delete(Guid id);
        Task<Response<bool>> Exist(Guid id);
    }
}
