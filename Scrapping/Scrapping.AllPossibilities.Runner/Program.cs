using Scrapping.AllPossibilities.Http;
using Scrapping.AllPossibilities.Selenium;

namespace Scrapping.AllPossibilities.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderBuilder.BuildOwnHeaders(new HeaderModel() {Accept_Charset = ""});
            var chromeDriver = ChromeDriverBuilder.CreateChromeDriver(new BuilderModel { Incognito = true });
            chromeDriver.Navigate().GoToUrl("https://www.youtube.com/");
        }
    }
}
