using System;
using System.Collections.Generic;

namespace Nomina.Core.DomainEntities
{ 
    public partial class Employee : BaseClass
    {
        public int CompanyId { get; set; }
        public int? DocumentIdentityTypeId { get; set; }
        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? GenderId { get; set; }
        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? MunicipalityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Mail { get; set; }
        public int PaymetshapeId { get; set; }
        public int BankId { get; set; }
        public int AcountTypeId { get; set; }
        public string AcountNumber { get; set; }
        public int ContractTypeId { get; set; }
        public DateTime? InitialContractDate { get; set; }
        public DateTime? EndContractDate { get; set; }
        public int SalaryTypeId { get; set; }
        public DateTime? InitialSalaryDate { get; set; }
        public DateTime? EndSalaryDate { get; set; }
        public int EmpoyeeGroupId { get; set; }
        public int OrganizationalUnitId { get; set; }
        public int ProcessId { get; set; }
        public int BranchOffice { get; set; }
        public int CostCenterId { get; set; }
        public int PositionId { get; set; }
        public int WorkingHourId { get; set; }
        public int WorkPlaceId { get; set; }
        public bool TransportAssistance { get; set; }
        public bool VariableSalary { get; set; }
        public int? HealthEntity { get; set; }
        public int? PensionEntity { get; set; }
        public int? Arpentity { get; set; }
        public int? SeveranceFund { get; set; }
        public int? CompensationFund { get; set; }

                
    }
}
