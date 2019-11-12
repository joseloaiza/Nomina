using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class CompanyBank
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid BanckId { get; set; }
        public Guid AccountTypeId { get; set; }
        public string AccountNumber { get; set; }
        public bool Main { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Bank Banck { get; set; }
        public virtual Company Company { get; set; }
    }
}
