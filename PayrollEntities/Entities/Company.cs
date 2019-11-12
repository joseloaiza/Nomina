using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Company
    {
        public Company()
        {
            CompanyArea = new HashSet<CompanyArea>();
            CompanyBank = new HashSet<CompanyBank>();
            CompanyCostCenter = new HashSet<CompanyCostCenter>();
            CompanyEmployee = new HashSet<CompanyEmployee>();
            CompanyEmployeeGroup = new HashSet<CompanyEmployeeGroup>();
            CompanyLaw = new HashSet<CompanyLaw>();
            CompanyOrganizationalUnit = new HashSet<CompanyOrganizationalUnit>();
            CompanyPayrollArea = new HashSet<CompanyPayrollArea>();
            CompanyPosition = new HashSet<CompanyPosition>();
            CompanyProcess = new HashSet<CompanyProcess>();
            CompanySubsidiary = new HashSet<CompanySubsidiary>();
            Concept = new HashSet<Concept>();
            Subsidiary = new HashSet<Subsidiary>();
        }

        public Guid Id { get; set; }
        public string Identification { get; set; }
        public string VerificationNumber { get; set; }
        public string Name { get; set; }
        public Guid CityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LegalRepresentant { get; set; }
        public DateTime FundationDate { get; set; }
        public Guid EntityRisksId { get; set; }
        public Guid CompensationFundId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CompanyArea> CompanyArea { get; set; }
        public virtual ICollection<CompanyBank> CompanyBank { get; set; }
        public virtual ICollection<CompanyCostCenter> CompanyCostCenter { get; set; }
        public virtual ICollection<CompanyEmployee> CompanyEmployee { get; set; }
        public virtual ICollection<CompanyEmployeeGroup> CompanyEmployeeGroup { get; set; }
        public virtual ICollection<CompanyLaw> CompanyLaw { get; set; }
        public virtual ICollection<CompanyOrganizationalUnit> CompanyOrganizationalUnit { get; set; }
        public virtual ICollection<CompanyPayrollArea> CompanyPayrollArea { get; set; }
        public virtual ICollection<CompanyPosition> CompanyPosition { get; set; }
        public virtual ICollection<CompanyProcess> CompanyProcess { get; set; }
        public virtual ICollection<CompanySubsidiary> CompanySubsidiary { get; set; }
        public virtual ICollection<Concept> Concept { get; set; }
        public virtual ICollection<Subsidiary> Subsidiary { get; set; }
    }
}
