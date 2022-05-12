using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SouceDemoSpecflow.StepDefinitions
{
    [Binding]
    public sealed class SauceDemoStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        IWebDriver driver = new ChromeDriver();

        [Given(@"I open ""([^""]*)"" page")]
        public void GivenIOpenPage(string souceDemo)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then(@"the login screen shall have ""([^""]*)"" textbox\. It is enabled and empty\.")]
        public void ThenTheLoginScreenShallHaveUsernameTextbox_ItIsEnabledAndEmpty_(string textbox)
        {
            switch (textbox)
            {
                case "Username":
                    IWebElement usertextbox = driver.FindElement(By.Name("user-name"));
                    string usertextboxtext = usertextbox.GetAttribute("value");
                    if (usertextbox.Enabled && string.IsNullOrEmpty(usertextboxtext))
                    {
                        Console.WriteLine("Username field is enabled and empty");
                    }
                    break;

                case "Password":
                    IWebElement passwordtextbox = driver.FindElement(By.Name("password"));
                    string passwordtextboxtext = passwordtextbox.GetAttribute("value");
                    if (passwordtextbox.Enabled && string.IsNullOrEmpty(passwordtextboxtext))
                    {
                        Console.WriteLine("Password field is enabled and empty");
                    }
                    break;
            }
        }

        [Then(@"the login screen shall have ""([^""]*)"" button\. It is enabled\.")]
        public void ThenTheLoginScreenShallHaveButton_ItIsEnabled_(string login)
        {
            IWebElement loginbutton = driver.FindElement(By.Name("login-button"));
            if (loginbutton.Enabled)
            {
                Console.WriteLine("Login button is enabled");
            }
        }

        [When(@"I log in with correct username and password the Home page is opened")]
        public void WhenILogInWithCorrectUsernameAndPasswordTheHomePageIsOpened()
        {
            IWebElement usertextbox = driver.FindElement(By.Name("user-name"));
            usertextbox.SendKeys("standard_user");

            IWebElement passwordtextbox = driver.FindElement(By.Name("password"));
            passwordtextbox.SendKeys("secret_sauce");

            IWebElement loginbutton = driver.FindElement(By.Name("login-button"));
            loginbutton.Click();
        }
    }
}