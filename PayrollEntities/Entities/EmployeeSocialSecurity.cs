using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class EmployeeSocialSecurity
    {
        //public EmployeeSocialSecurity()
        //{
        //    InverseEntityCesantias = new HashSet<EmployeeSocialSecurity>();
        //    InverseEntityPension = new HashSet<EmployeeSocialSecurity>();
        //}

        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid EntitySaludId { get; set; }
        public Guid EntityPensionId { get; set; }
        public Guid EntityCesantiasId { get; set; }
        public Guid TypeOfContributorId { get; set; }
        public Guid SubTypeOfContributorId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        //public virtual Employee Employee { get; set; }
        //public virtual EmployeeSocialSecurity EntityCesantias { get; set; }
        //public virtual EmployeeSocialSecurity EntityPension { get; set; }
        //public virtual SocialSecurityEntity EntitySalud { get; set; }
        //public virtual ContributorSubType SubTypeOfContributor { get; set; }
        //public virtual ContributorType TypeOfContributor { get; set; }
        //public virtual ICollection<EmployeeSocialSecurity> InverseEntityCesantias { get; set; }
        //public virtual ICollection<EmployeeSocialSecurity> InverseEntityPension { get; set; }
    }
}
