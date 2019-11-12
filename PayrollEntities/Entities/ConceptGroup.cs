using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class ConceptGroup
    {
        public ConceptGroup()
        {
            Concept = new HashSet<Concept>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Concept> Concept { get; set; }
    }
}
