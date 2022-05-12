using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class SauceDemoTest
    {
        public static void Main(string[] args)
        {
            //create the reference for the driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to https://www.saucedemo.com/
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            //Login screen shall have "Username" textbox. It is enabled and empty.
            IWebElement usertextbox = driver.FindElement(By.Name("user-name"));
            string usertextboxtext = usertextbox.GetAttribute("value");
            if (usertextbox.Enabled && string.IsNullOrEmpty(usertextboxtext))
            {
                Console.WriteLine("Username field is enabled and empty");
            }

            //Login screen shall have "Password" textbox. It is enabled and empty.
            IWebElement passwordtextbox = driver.FindElement(By.Name("password"));
            string passwordtextboxtext = passwordtextbox.GetAttribute("value");
            if (passwordtextbox.Enabled && string.IsNullOrEmpty(passwordtextboxtext))
            {
                Console.WriteLine("Password field is enabled and empty");
            }

            //Login screen shall have "Login" button. It is enabled.
            IWebElement loginbutton = driver.FindElement(By.Name("login-button"));
            if (loginbutton.Enabled)
            {
                Console.WriteLine("Login button is enabled");
            }

            //I log in with username and password
            usertextbox.SendKeys("standard_user");
            passwordtextbox.SendKeys("secret_sauce");
            loginbutton.Click();
            driver.Close();
        }


    }
}
