using System;
using System.Collections.Generic;

namespace Payroll.Models.Entities
{
    public partial class Employee: BaseClass
    {
        //public Employee()
        //{
        //    CompanyEmployee = new HashSet<CompanyEmployee>();
        //    EmployeeContract = new HashSet<EmployeeContract>();
        //    EmployeeJob = new HashSet<EmployeeJob>();
        //    EmployeePayment = new HashSet<EmployeePayment>();
        //    EmployeeRecurringConcept = new HashSet<EmployeeRecurringConcept>();
        //    EmployeeSalary = new HashSet<EmployeeSalary>();
        //    EmployeeSocialSecurity = new HashSet<EmployeeSocialSecurity>();
        //    EmployeeWorking = new HashSet<EmployeeWorking>();
        //}


        public Guid CompanyId { get; set; }
        public Guid DocumentIdentityTypeId { get; set; }
        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string SurName { get; set; }
        public string SecondSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid GenderId { get; set; }
        public Guid CityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }

        //public virtual ICollection<CompanyEmployee> CompanyEmployee { get; set; }
        //public virtual ICollection<EmployeeContract> EmployeeContract { get; set; }
        //public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
        //public virtual ICollection<EmployeePayment> EmployeePayment { get; set; }
        //public virtual ICollection<EmployeeRecurringConcept> EmployeeRecurringConcept { get; set; }
        //public virtual ICollection<EmployeeSalary> EmployeeSalary { get; set; }
        //public virtual ICollection<EmployeeSocialSecurity> EmployeeSocialSecurity { get; set; }
        //public virtual ICollection<EmployeeWorking> EmployeeWorking { get; set; }
    }
}
