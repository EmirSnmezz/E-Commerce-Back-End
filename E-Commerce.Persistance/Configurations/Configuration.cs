using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_Commerce.Persistance.Configurations
{
    public static class Configuration
    {
        public static string ConnectionString 
        {
            get
            {
                ConfigurationManager config = new();
                config.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/E-CommerceBackEnd.API"));
                config.AddJsonFile("appsettings.json");
                return config.GetConnectionString("PostgreSQL");
            }
        }
    }
}
