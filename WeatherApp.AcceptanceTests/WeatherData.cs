using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.AcceptanceTests
{
    public class WeatherData
    {
        public WeatherData(string humidity, string temperature, string location)
        {
            Humidity = humidity;
            Temperature = temperature;
            Location = location;
        }

        public string Humidity { get; set; }
        public string Temperature { get; set; }
        public string Location { get; set; }
    }
}
