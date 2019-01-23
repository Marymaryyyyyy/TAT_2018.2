using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task_DEV_9
{
    public class AuthorizationPage
    {
        private readonly By LoginArea = By.XPath("//input[@name='email']");
        private readonly By PasswordArea = By.XPath("//input[@id='quick_pass']");
        private readonly By LoginButton = By.CssSelector("//input[@id='quick_login_button']"); 
        private IWebDriver webDriver;

        public AuthorizationPage(IWebDriver webdriver)
        {
            this.webDriver = webdriver;
        }

        public ProfilePage LogIn()
        {
            WaitForElement(LoginArea);
            IWebElement login = webDriver.FindElement(LoginArea);
            login.SendKeys("rkkfkkffkkf");
            webDriver.FindElement(PasswordArea).SendKeys("jfjfffkfk");
            webDriver.FindElement(LoginButton).Click();
            return new ProfilePage(webDriver);
        }

        private void WaitForElement(By locator)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}