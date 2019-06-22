

namespace Nomina.Infrastructure
{
    using Nomina.Infraestructure;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.Extensions.Configuration;

    public class DatabaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "DefaultConnection";

       
        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }

        //public string GetAuthConnectionString()
        //{
        //    return GetConfiguration().GetConnectionString(AuthConnectionKey);
        //}
    }
}
