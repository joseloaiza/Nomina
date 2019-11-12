using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class EmployeeWorking
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ContractRegimeId { get; set; }
        public Guid WorkPlaceRisksId { get; set; }
        public Guid WorkingHourId { get; set; }
        public bool TransportAssistence { get; set; }
        public bool VariableSalary { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ContractRegime ContractRegime { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual WorkPlaceRisks WorkPlaceRisks { get; set; }
        public virtual WorkingHour WorkingHour { get; set; }
    }
}
