using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class SalaryType
    {
        public SalaryType()
        {
            EmployeeSalary = new HashSet<EmployeeSalary>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<EmployeeSalary> EmployeeSalary { get; set; }
    }
}
