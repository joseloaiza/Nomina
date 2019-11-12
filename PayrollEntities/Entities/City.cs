using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class City
    {
        public City()
        {
            Bank = new HashSet<Bank>();
            SocialSecurityEntity = new HashSet<SocialSecurityEntity>();
            Subsidiary = new HashSet<Subsidiary>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid StateId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Bank> Bank { get; set; }
        public virtual ICollection<SocialSecurityEntity> SocialSecurityEntity { get; set; }
        public virtual ICollection<Subsidiary> Subsidiary { get; set; }
    }
}
