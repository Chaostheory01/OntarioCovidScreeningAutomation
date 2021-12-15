using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace CovidScreeningApp
{
    class Program
    {
        private static readonly int DelayInMilliseconds = (int)TimeSpan.FromSeconds(0.5).TotalMilliseconds;

        static async Task Main(string[] args)
        {   
            using var webDriver = new ChromeDriver();
            await ExecuteActionAndPause(() => webDriver.Navigate().GoToUrl(@"https://covid-19.ontario.ca/school-screening/"));
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='Start school screening']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.Id("guardian")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='Continue']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='Continue']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//button[text()='No']")).Click());
            await ExecuteActionAndPause(() => webDriver.FindElement(By.XPath(@"//div[text()='Download result (PDF)']")).Click());
            await Task.Delay(TimeSpan.FromSeconds(10)); // wait for download to complete
        }

        private static async Task ExecuteActionAndPause(Action a)
        {
            await Task.Delay(DelayInMilliseconds);
            a();
        }
    }
}
