using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task2_3
{
    class MailRuPage
    {
        IWebDriver browser;
        WebDriverWait wait;

        public MailRuPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
            browser.Navigate().GoToUrl("https://mail.ru");
            browser.Manage().Window.Maximize();
        }
        public void Authorize(string login, string password)
        {
            IWebElement loginField = browser.FindElement(By.Id("mailbox:login"));
            loginField.SendKeys(login + Keys.Enter);
            IWebElement passswordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            passswordField.SendKeys(password + Keys.Enter);
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='app-canvas']")));
        }
    }
}
