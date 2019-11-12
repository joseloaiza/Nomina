using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Subsidiary
    {
        public Subsidiary()
        {
            CompanySubsidiary = new HashSet<CompanySubsidiary>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CompanySubsidiary> CompanySubsidiary { get; set; }
    }
}
