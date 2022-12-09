using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject
{
   
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\Izabela\\Projects\\Selenium\\SeleniumProject\\SeleniumProject\\Resources");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.pl");
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit(); //close web browser + driver
            //driver.Close(); //close web browser
        }
    }
}