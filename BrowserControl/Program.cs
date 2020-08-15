using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//^^ when grabbing the NUGET package selenium, you also need to install the chrome drivers from the selenium package. 


namespace BrowserControl
{
    
    class Program
    {

        
        static void Main(string[] args)
        {
            string mySearch1;

            Console.WriteLine("What Would You Like To Search For?");
            mySearch1 = Console.ReadLine();

            // in the terminal run: dotnet run
            //"dotnet run" will open the chrome browswer and run the program. 
            IWebDriver driver = new ChromeDriver(@"C:\Users\Sekol_Michael\source\repos\BrowserControl\BrowserControl\bin\Debug\netcoreapp3.1");
            IWebDriver ffDriver = new FirefoxDriver(@"C:\Users\Sekol_Michael\source\repos\BrowserControl\BrowserControl\bin\Debug\netcoreapp3.1");
            driver.Url = "https://www.google.com";
            ffDriver.Url = "https://www.bing.com";

            // Console.WriteLine(driver.Title);
            IWebElement textbox = driver.FindElement(By.Name("q"));
            IWebElement fftextbox = ffDriver.FindElement(By.Name("q"));
            textbox.SendKeys(mySearch1);
            fftextbox.SendKeys(mySearch1);
            textbox.Submit();
            fftextbox.Submit();
            // Console.WriteLine(driver.Title);

            // driver.Quit(); Closes the browser
            Console.WriteLine("Just checking the version control...");
            Console.ReadLine();

        }
    }
}
