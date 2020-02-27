using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace NUnitSiteTest
{
    public class Tests
    {
        IWebDriver browser;

        [OneTimeSetUp]
        public void Setup()
        {
            browser = new ChromeDriver();
        }
        
        [Test]
        public void AddingFiftyGuest()
        {
            browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");

            PersonalInfo actualInfo = new PersonalInfo("Vasily", "vasily@gmail.com", "+375292722020");
            List<PersonalInfo> actualInfos = new List<PersonalInfo>();
            for(int i = 0; i < 50; i++)
            {
                browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");
                actualInfos.Add(actualInfo);
                actualInfo.Send(browser);
                IWebElement attendance = browser.FindElement(By.XPath("//*[@name='willattend']/option[@value='true']"));
                attendance.Click();
                IWebElement sendButton = browser.FindElement(By.XPath("//button"));
                sendButton.Click();
            }

            Assert.AreEqual(PersonalInfo.GetFromTable(browser, true).Count, actualInfos.Count);
        }

        [Test]
        public void AddingFiftyMissing()
        {
            browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");

            PersonalInfo actualInfo = new PersonalInfo("Elizaveta", "elizabeth@gmail.com", "+375332822020");
            List<PersonalInfo> actualInfos = new List<PersonalInfo>();
            for (int i = 0; i < 50; i++)
            {
                browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");
                actualInfos.Add(actualInfo);
                actualInfo.Send(browser);
                IWebElement attendance = browser.FindElement(By.XPath("//*[@name='willattend']/option[@value='false']"));
                attendance.Click();
                IWebElement sendButton = browser.FindElement(By.XPath("//button"));
                sendButton.Click();
            }

            Assert.AreEqual(PersonalInfo.GetFromTable(browser, false).Count, actualInfos.Count);
        }

        [Test]
        public void SeeYouThereTest()
        {
            browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");

            PersonalInfo actualInfo = new PersonalInfo("Philipp", "philip.shpyro@gmail.com", "+375291260870");
            actualInfo.Send(browser);

            IWebElement attendance = browser.FindElement(By.XPath("//*[@name='willattend']/option[@value='true']"));
            attendance.Click();

            IWebElement sendButton = browser.FindElement(By.XPath("//button"));
            sendButton.Click();

            Assert.AreEqual("http://localhost:50220/seeyouthere.html", browser.Url);
        }

        [Test]
        public void SorryYouCantComeTest()
        {
            browser.Navigate().GoToUrl("http://localhost:50220/Default.aspx");

            PersonalInfo actualInfo = new PersonalInfo("Philipp", "philip.shpyro@gmail.com", "+375291260870");
            actualInfo.Send(browser);

            IWebElement attendance = browser.FindElement(By.XPath("//*[@name='willattend']/option[@value='false']"));
            attendance.Click();

            IWebElement sendButton = browser.FindElement(By.XPath("//button"));
            sendButton.Click();

            Assert.AreEqual("http://localhost:50220/sorryyoucantcome.html", browser.Url);
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}
