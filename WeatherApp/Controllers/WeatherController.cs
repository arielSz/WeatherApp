using System.Web.Http;

using WeatherApp.Models;
using WeatherApp.Services;


namespace WeatherApp.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWeather _weatherService;
        public WeatherController(IWeather weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("api/weather/{country}/{city}")]
        public WeatherJson GetWeather(string country, string city)
        {
            var a = _weatherService.getWeather(city, country);
            
            return new WeatherJson(a.Name, a.Sys.Country, a.Main.Temp, a.Main.Humidity);
        }
    }
    
}
