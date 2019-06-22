﻿using System;
using System.Collections.Generic;

namespace Nomina.Core.DomainEntities
{
    public partial class PaymentFrecuency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
