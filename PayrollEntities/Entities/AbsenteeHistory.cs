using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class AbsenteeHistory
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid AbsenteeTypeId { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public decimal BaseAbsentee { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual AbsenteeType AbsenteeType { get; set; }
    }
}
