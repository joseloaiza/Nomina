
namespace Payroll.Infrastructure
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Text;
    using Payroll.Models.Entities;
    


    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
            

        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Subsidiary> BranchOffice { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<State> Department { get; set; }
        public virtual DbSet<EmbargoType> EmbargoType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmpoyeeGroup> EmpoyeeGroup { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<MotiveLiqContract> MotiveLiqContract { get; set; }
        public virtual DbSet<City> Municipality { get; set; }
        public virtual DbSet<OrganizationalUnit> OrganizationalUnit { get; set; }
        public virtual DbSet<PaymentMethod> Paymetshape { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<SalaryType> SalaryType { get; set; }
        public virtual DbSet<SocialSecurityEntity> Ssentity { get; set; }

       

    }
}
