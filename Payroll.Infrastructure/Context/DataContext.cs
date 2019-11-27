namespace Payroll.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Payroll.Models.Entities;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }                  

        public virtual DbSet<Country> Country { get; set; }
    }
}
