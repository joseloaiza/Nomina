using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Period
    {
        public Period()
        {
            Movement = new HashSet<Movement>();
        }

        public Guid Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Period1 { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid PeriodStatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual PeriodStatus PeriodStatus { get; set; }
        public virtual ICollection<Movement> Movement { get; set; }
    }
}
