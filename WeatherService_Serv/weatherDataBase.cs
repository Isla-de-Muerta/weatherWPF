using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService_Serv
{
    public class weatherDataBase
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public string name { get; set; }
    }
}