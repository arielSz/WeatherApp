using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Controllers;
using Xunit;
using NSubstitute;
using WeatherApp.Services;
using WeatherApp.Models;

namespace WeatherApp.UnitTests
{
    public class WeatherControllerUnitTests
    {
        [Fact]
        public void WeatherController_CheckDataExistance()
        {
            WeatherService repository = Substitute.For<WeatherService>();
            var controller = new WeatherController(repository);

            var response = controller.GetWeather("PL", "Warsaw");

            Assert.NotNull(response);
        }
        [Fact]
        public void WeatherController_CheckDataCompatibility()
        {
            WeatherService repository = Substitute.For<WeatherService>();
            var controller = new WeatherController(repository);

            var response = controller.GetWeather("PL", "Warsaw");

            Assert.Equal("Warsaw", response.Location.City);
        }
    }
}

