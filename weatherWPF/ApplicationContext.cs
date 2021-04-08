using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService_Serv;

namespace weatherWPF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<weatherDataBase> weatherDataBases { get; set; }
        public ApplicationContext() : base("weathers.db")
        {

        }
    }
}
