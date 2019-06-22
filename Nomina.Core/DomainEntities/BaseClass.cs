using System;
using System.Collections.Generic;
using System.Text;

namespace Nomina.Core.DomainEntities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
