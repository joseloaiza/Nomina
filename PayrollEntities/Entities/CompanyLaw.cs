using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class CompanyLaw
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid LawId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual Company Company { get; set; }
        public virtual Law Law { get; set; }
    }
}
