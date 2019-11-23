using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Country
    {
        public Country()
        {
            //State = new HashSet<State>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
