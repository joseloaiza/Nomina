using System;
using System.Collections.Generic;

namespace Nomina.Core.DomainEntities
{
    public partial class BranchOffice
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public int Countryid { get; set; }
        public int Departmentid { get; set; }
        public int Municipalityid { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
