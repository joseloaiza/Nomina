
namespace Nomina.Web.Data
{
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Nomina.Core.DomainEntities;


    public class DataContext: DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

    }
}
