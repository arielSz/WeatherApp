using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WeatherApp.AcceptanceTests
{

    class WeatherPage
    {
        private readonly IWebDriver _driver;

        private string url = "http://localhost:4200/";

        public WeatherPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateTo()
        {
            _driver.Navigate().GoToUrl(url);
        }
        public void CityInput(string input)
        {
            _driver.FindElement(By.Name("city")).SendKeys(input);
        }
        public void CountryInput(string input)
        {
            _driver.FindElement(By.Name("country")).SendKeys(input);
        }
        public void Submit()
        {
            _driver.FindElement(By.Name("localisationForm")).Submit();
        }
        public WeatherData GetData()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return new WeatherData(_driver.FindElement(By.Name("humidity")).Text,
                _driver.FindElement(By.Name("temperature")).Text,
                _driver.FindElement(By.Name("location")).Text);
        }
    }
}
