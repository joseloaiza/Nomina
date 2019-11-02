using System;
using System.Collections.Generic;
using System.Text;
using Nomina.Core.DomainEntities;
using Nomina.Core.RepositoriesInterfaces;
using Nomina.Infrastructure.Context;

namespace Nomina.Infrastructure.Repositories
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext context)
          : base(context)
        {
        }

    }
}
