using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class EmployeeJob
    {
        //public EmployeeJob()
        //{
        //    Movement = new HashSet<Movement>();
        //}

        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CompanyOrganizationalUnitId { get; set; }
        public Guid CompanyEmployeeGroupId { get; set; }
        public Guid CompanyProcessId { get; set; }
        public Guid CompanyAreaId { get; set; }
        public Guid CompanySubsidiaryId { get; set; }
        public Guid CompanyCostCenterId { get; set; }
        public Guid CompanyPositionId { get; set; }
        public Guid CompanyPayrollAreaId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        //public virtual CompanyArea CompanyArea { get; set; }
        //public virtual CompanyCostCenter CompanyCostCenter { get; set; }
        //public virtual CompanyEmployeeGroup CompanyEmployeeGroup { get; set; }
        //public virtual CompanyOrganizationalUnit CompanyOrganizationalUnit { get; set; }
        //public virtual CompanyPayrollArea CompanyPayrollArea { get; set; }
        //public virtual CompanyPosition CompanyPosition { get; set; }
        //public virtual CompanyProcess CompanyProcess { get; set; }
        //public virtual CompanySubsidiary CompanySubsidiary { get; set; }
        //public virtual Employee Employee { get; set; }
        //public virtual ICollection<Movement> Movement { get; set; }
    }
}
