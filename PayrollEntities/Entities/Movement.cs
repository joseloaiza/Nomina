using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Movement
    {
        public Guid Id { get; set; }
        public Guid EmployeeJobId { get; set; }
        public Guid PeriodId { get; set; }
        public Guid MovementTypeId { get; set; }
        public Guid ConceptId { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual Concept Concept { get; set; }
        public virtual EmployeeJob EmployeeJob { get; set; }
        public virtual MovementType MovementType { get; set; }
        public virtual Period Period { get; set; }
    }
}
