using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task2_3
{
    class MailMessageWriter
    {
        IWebDriver browser;
        WebDriverWait wait;

        public MailMessageWriter(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
            browser.Navigate().GoToUrl("https://mail.ru/");
        }
        public void Write(string message)
        {
            IWebElement writeLetterButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='mailbox:write_letter']/div")));
            writeLetterButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[class=container--H9L5q size_s--3_M-_]"))).Click();
            browser.FindElement(By.XPath("//*")).SendKeys("johnmarrewood@gmail.com");
            browser.FindElement(By.CssSelector("div[role=textbox]")).SendKeys("Hello");
        }
    }
}
