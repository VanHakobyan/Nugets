using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapping.AllPossibilities.Selenium;

namespace Scrapping.AllPossibilities.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeDriver = ChromeDriverBuilder.CreateChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://www.youtube.com/");
        }
    }
}
