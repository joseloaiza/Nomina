

namespace Payroll.Models
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseClass
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
