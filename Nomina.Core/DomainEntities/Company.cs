using System;
using System.Collections.Generic;

namespace Nomina.Core.DomainEntities
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string VerificationDigit { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? MunicipalityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string LegalRepresentant { get; set; }
        public DateTime? FundationDate { get; set; }
        public bool Active { get; set; }
        public int PaymenFrecuencytId { get; set; }
        public int PaymentShapeId { get; set; }
        public int BankId { get; set; }
        public int AcountTypeId { get; set; }
        public string AcountNumber { get; set; }
        public int Arlid { get; set; }
        public bool Law1429 { get; set; }
        public bool Law590 { get; set; }
        public bool Law1607 { get; set; }
    }
}
