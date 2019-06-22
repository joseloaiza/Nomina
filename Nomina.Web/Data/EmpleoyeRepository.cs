
namespace Nomina.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Nomina.Core.DomainEntities;


    public class EmpleoyeRepository : GenericRepository<Employees>,  IEmpleoyeRepository
    {
        public EmpleoyeRepository(DataContext context) : base(context)
        {

        }

    }
}
