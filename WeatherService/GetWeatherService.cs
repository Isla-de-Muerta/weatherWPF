using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherService
{
    public class GetWeatherService
    {
        private string apiConectionString = "api.openweathermap.org/data/2.5/weather";
        private string apiKey = "1dfe39974aeee20224a284064b77134f";

        public void GetWeather(string city)
        {
            var client = new RestClient(apiConectionString);
            var request = new RestRequest(Method.GET);

            request.AddParameter("q", city);
            request.AddParameter("appid", apiKey);

            var root = client.Execute<Root>(request).Data;
        }
    }
}