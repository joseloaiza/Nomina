﻿using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Concept
    {
        public Concept()
        {
            Movement = new HashSet<Movement>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ConceptGroupId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual Company Company { get; set; }
        public virtual ConceptGroup ConceptGroup { get; set; }
        public virtual ICollection<Movement> Movement { get; set; }
    }
}