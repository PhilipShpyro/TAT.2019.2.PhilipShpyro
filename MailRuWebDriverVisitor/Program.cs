using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_4
{
    class Program
    {
        const string LOGIN = "vpupchick";
        const string PASSWORD = "AutomatedVasya247";

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Philipp\source\repos\DEV_4\DEV_4\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://mail.ru");
            IWebElement loginField = driver.FindElement(By.Name("login"));
            loginField.SendKeys(LOGIN);
            IWebElement button = driver.FindElement(By.CssSelector("input[value='Ввести пароль']"));
            button.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement passswordField = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='password']")));
            passswordField.SendKeys(PASSWORD);
            button.Click();
            
            IWebElement msgNumber = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("badge__text")));
            Console.WriteLine("Number of unread messages " + msgNumber.Text);
            driver.Quit();
        }
    }
}
