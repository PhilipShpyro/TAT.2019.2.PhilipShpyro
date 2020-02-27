using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitSiteTest
{
    class PersonalInfo
    {
        public string Name { get; }
        public string Email { get; }
        public string Phone { get; }
        public PersonalInfo(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
        public void Send(IWebDriver browser)
        {
            IWebElement name = browser.FindElement(By.XPath("//*[@id='name']"));
            name.SendKeys(Name);

            IWebElement email = browser.FindElement(By.XPath("//*[@id='email']"));
            email.SendKeys(Email);

            IWebElement phone = browser.FindElement(By.XPath("//*[@id='phone']"));
            phone.SendKeys(Phone);
        }
        public static List<PersonalInfo> GetFromTable(IWebDriver browser, bool guests)
        {
            browser.Navigate().GoToUrl("http://localhost:50220/Summary.aspx");
            List<PersonalInfo> personals = new List<PersonalInfo>();
            List<IWebElement> elements = new List<IWebElement>();
            foreach (var node in browser.FindElements(By.XPath(guests == true ? "//table[1]/tbody/tr" : "//table[2]/tbody/tr")))
            {
                elements.Add(node);
            }
            for(int i = 0; i < elements.Count; i++)
            {
                string[] data = elements[i].Text.Split();
                personals.Add(new PersonalInfo(data[0], data[1], data[2]));
            }
            return personals;
        }
        public override string ToString()
        {
            return Name + " " + Email + " " + Phone;
        }
    }
}
