using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService : IWeather
    {
        public ResponseWeather getWeather(string city, string country)
        {
            string apiKey = "abbb2f8dc6c6e1effd5b8af550bdff9e";
            HttpWebRequest apiRequest = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + "," + country + "&appid=" + apiKey + "&units=metric") as HttpWebRequest;
             
            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }

            ResponseWeather rootObject = JsonConvert.DeserializeObject<ResponseWeather>(apiResponse);
            return rootObject;
        }
    }
}