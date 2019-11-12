using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class EmployeeContract
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ContractTypeId { get; set; }
        public DateTime InitialContractDate { get; set; }
        public DateTime EndContractDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ContractType ContractType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
