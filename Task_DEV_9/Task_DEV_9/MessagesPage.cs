using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Task_DEV_9
{
    public class AuthorizationPage
    {
        private IWebDriver webDriver;
        private readonly By Message = By.XPath("//span[contains(text(),'Сообщения')]");       
                
        public MessagesPage(IWebDriver webdriver)
        {
            this.webDriver = webdriver;
        }       

        private void WaitForElement(By locator)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
