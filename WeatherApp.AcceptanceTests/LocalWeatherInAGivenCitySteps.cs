using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace WeatherApp.AcceptanceTests
{
    [Binding]
    public class LocalWeatherInAGivenCitySteps
    {
        private WeatherPage WeatherPage = new WeatherPage(new FirefoxDriver());

        string city = "";

        [Given(@"a webpage with a form")]
        public void GivenAWebpageWithAForm()
        {
            WeatherPage.NavigateTo();
        }
        
        [Given(@"I type in '(.*)'")]
        public void GivenITypeIn(string countryTest)
        {
            WeatherPage.CountryInput(countryTest);
        }

        [Given(@"I also type in '(.*)'")]
        public void GivenIAlsoTypeIn(string cityTest)
        {
            WeatherPage.CityInput(cityTest);
            city = cityTest;
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            WeatherPage.Submit();
        }

        [Then(@"I receive the temperature and humidity conditions on the day for Warsaw, Poland according to the official weather reports")]
        public void ThenIReceiveTheTemperatureAndHumidityConditionsOnTheDayForWarsawPolandAccordingToTheOfficialWeatherReports()
        {
            WeatherData data = WeatherPage.GetData();

            Assert.IsNotNull(data.Temperature);
            Assert.IsNotNull(data.Humidity);
        }

        [Then(@"I receive the temperature and humidity conditions on the day for Gdansk, Poland according to the official weather reports")]
        public void ThenIReceiveTheTemperatureAndHumidityConditionsOnTheDayForGdanskPolandAccordingToTheOfficialWeatherReports()
        {
            WeatherData data = WeatherPage.GetData();

            Assert.IsNotNull(data.Temperature);
            Assert.IsNotNull(data.Humidity);
        }

        [Then(@"I receive the temperature and humidity conditions on the day for Berlin, Germany according to the official weather reports")]
        public void ThenIReceiveTheTemperatureAndHumidityConditionsOnTheDayForBerlinGermanyAccordingToTheOfficialWeatherReports()
        {
            WeatherData data = WeatherPage.GetData();

            Assert.IsNotNull(data.Temperature);
            Assert.IsNotNull(data.Humidity);
        }
    }
}
