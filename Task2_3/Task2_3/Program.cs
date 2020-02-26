using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver browser = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(browser, new TimeSpan(0, 0, 30));

            MailRuPage mailRu = new MailRuPage(browser, wait);
            mailRu.Authorize("vpupchick", "AutomatedVasya247");

            

            MailMessageWriter messageWriter = new MailMessageWriter(browser, wait);
            messageWriter.Write("a");
        }
    }
}
