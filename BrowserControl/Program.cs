using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace BrowserControl
{
    class Program
    {
        static void Main(string[] args)
        {

            // in the terminal run: dotnet run
            //"dotnet run" will open the chrome browswer and run the program. 
            IWebDriver driver = new ChromeDriver(@"C:\Users\Sekol_Michael\source\repos\BrowserControl\BrowserControl\bin\Debug\netcoreapp3.1");
            //IWebDriver ffDriver = new FirefoxDriver(@"C:\Users\Sekol_Michael\source\repos\BrowserControl\BrowserControl\bin\Debug\netcoreapp3.1");
            driver.Url = "https://www.google.com";

            // Console.WriteLine(driver.Title);
            IWebElement textbox = driver.FindElement(By.Name("q"));
            textbox.SendKeys("Bushido");
            textbox.Submit();
            // Console.WriteLine(driver.Title);

            // driver.Quit(); Closes the browser
        }
    }
}
