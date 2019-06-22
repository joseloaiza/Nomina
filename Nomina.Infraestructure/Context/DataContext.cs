
namespace Nomina.Infrastructure.Context
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Text;
    using Nomina.Core.DomainEntities;

    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

     

        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BranchOffice> BranchOffice { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmbargoType> EmbargoType { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmpoyeeGroup> EmpoyeeGroup { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<MotiveLiqContract> MotiveLiqContract { get; set; }
        public virtual DbSet<Municipality> Municipality { get; set; }
        public virtual DbSet<OrganizationalUnit> OrganizationalUnit { get; set; }
        public virtual DbSet<PaymentFrecuency> PaymentFrecuency { get; set; }
        public virtual DbSet<Paymetshape> Paymetshape { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<SalaryType> SalaryType { get; set; }
        public virtual DbSet<Ssentity> Ssentity { get; set; }

       

    }
}
