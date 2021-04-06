using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService_Serv
{
    public class Main
    {
        private double kelvin = 273.15;
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }

        public void ConventToCelsius()
        {
            temp = temp - kelvin;
            temp_max = temp_max - kelvin;
            temp_min = temp_min - kelvin;
            feels_like = feels_like - kelvin;
        }
    }
}
