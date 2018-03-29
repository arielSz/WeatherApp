using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class WeatherJson
    {
        public WeatherJson(string city, string country, double value, double humidity)
        {
            this.Location = new Location(city, country); 
            this.Temperature = new Temperature("Celcius", value);
            this.Humidity = humidity;
        }

        public Location Location { get; set; }
        public Temperature Temperature { get; set; }
        public double Humidity { get; set; }
    }

    public class Temperature
    {
        public Temperature(string format, double value)
        {
            this.Format = format;
            this.Value = value;
        }

        public string Format { get; set; }
        public double Value { get; set; }
    }

    public class Location
    {
        public Location(string city, string country)
        {
            this.City = city;
            this.Country = country;
        }

        public string City { get; set; }
        public string Country { get; set; }
    }

}