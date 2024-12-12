using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderItem.Infrastructure.Configurations
{
    public class DatabaseConfig
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public string GetConnectionString()
        {
            return $"Host={Host};Username={Username};Password={Password};Database={Database}";
        }
    }
}
