using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class GoogleTest
    {
        public static void Main(string[] args)
        {
            //create the reference for the driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to https://www.google.com/
            driver.Navigate().GoToUrl("https://www.google.com/");

            //identify terms of service button
            IWebElement accepttos = driver.FindElement(By.Id("L2AGLb"));

            //accept terms of service
            accepttos.Click();

            //identify google search box
            IWebElement search = driver.FindElement(By.Name("q"));

            //search lord of the rings on google
            search.SendKeys("lord of the rings");
            search.SendKeys(Keys.Return);

            //exit browser
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}