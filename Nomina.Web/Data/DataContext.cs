
namespace Nomina.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Nomina.Web.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class DataContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

    }
}
