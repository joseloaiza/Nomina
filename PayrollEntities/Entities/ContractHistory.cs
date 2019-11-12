using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class ContractHistory
    {
        public string EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int ContractTypeId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
