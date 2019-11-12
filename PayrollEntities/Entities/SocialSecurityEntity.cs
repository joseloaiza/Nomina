using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class SocialSecurityEntity
    {
        public SocialSecurityEntity()
        {
            EmployeeSocialSecurity = new HashSet<EmployeeSocialSecurity>();
        }

        public Guid Id { get; set; }
        public Guid SocialSecurityEntityTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string VerificationNumber { get; set; }
        public Guid CityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual SocialSecurityEntityType SocialSecurityEntityType { get; set; }
        public virtual ICollection<EmployeeSocialSecurity> EmployeeSocialSecurity { get; set; }
    }
}
