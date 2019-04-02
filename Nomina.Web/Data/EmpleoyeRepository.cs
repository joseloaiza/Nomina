
namespace Nomina.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;


    public class EmpleoyeRepository : GenericRepository<Empleoye>, IEmpleoyeRepository
    {
        public EmpleoyeRepository(DataContext context) : base(context)
        {

        }

    }
}
