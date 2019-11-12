using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class EmployeePayment
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid BanckId { get; set; }
        public Guid AccountTypeId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Bank Banck { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
