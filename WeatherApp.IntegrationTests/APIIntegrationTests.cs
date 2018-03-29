using Newtonsoft.Json;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Controllers;
using WeatherApp.Models;
using WeatherApp.Services;
using Xunit;


namespace WeatherApp.IntegrationTests
{
    public class APIIntegrationTests
    {
        [Fact]
        public void APIIntegration_CheckResponse()
        {
            string apiKey = "abbb2f8dc6c6e1effd5b8af550bdff9e";
            HttpWebRequest apiRequest = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=London,uk" + "&appid=" + apiKey + "&units=metric") as HttpWebRequest;

            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }

            ResponseWeather rootObject = JsonConvert.DeserializeObject<ResponseWeather>(apiResponse);

            Assert.NotNull(rootObject);
        }
    }
}
