using System;
using System.Collections.Generic;

namespace Nomina.Core.DomainEntities
{
    public partial class Employees : BaseClass
    {
        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Adress { get; set; }
        public int? ContractType { get; set; }
        public DateTime? ContractDate { get; set; }
        public string Position { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Cellphone { get; set; }
        public string Phone { get; set; }
        public int? Bank { get; set; }
        public int? PaymentMethod { get; set; }
        public int? AccountType { get; set; }
        public string AccountNumber { get; set; }
       
    }
}
