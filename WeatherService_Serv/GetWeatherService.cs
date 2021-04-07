using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService_Serv
{
    public class GetWeatherService: IDisposable
    {
        private string apiConectionString = "https://api.openweathermap.org/data/2.5/weather";
        private string apiKey = "1dfe39974aeee20224a284064b77134f";

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Root GetWeather(string city)
        {
            var client = new RestClient(apiConectionString);
            var request = new RestRequest(Method.GET);

            request.AddParameter("q", city);
            request.AddParameter("appid", apiKey);

            var root = client.Execute<Root>(request);
            return root.IsSuccessful ? root.Data : null;
        }
    }
}
