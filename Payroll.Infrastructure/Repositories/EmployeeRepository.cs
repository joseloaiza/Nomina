

//using Nomina.Core.DomainEntities;
//using Nomina.Core.RepositoriesInterfaces;
//using Nomina.Infrastructure.Context;

namespace Payroll.Infrastructure
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using Payroll.Models.Entities;
    
   

    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext context)
          : base(context)
        {
        }

    }
}
