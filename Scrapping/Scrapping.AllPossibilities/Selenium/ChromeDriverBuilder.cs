using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Scrapping.AllPossibilities.Selenium
{
    public class ChromeDriverBuilder
    {
        /// <summary>
        /// Build your chrome driver 
        /// </summary>
        /// <param name="builderModel"></param>
        /// <param name="ip"> Example  126:13:142:11:8069</param>
        /// <returns></returns>
        public static ChromeDriver CreateChromeDriver(BuilderModel builderModel, string ip = null)
        {
            var chromeOptions = new ChromeOptions();

            if (builderModel.DisableExtensions) chromeOptions.AddArgument(OptionArgumentStatics.DisableExtensions);
            if (builderModel.DisableGpu) chromeOptions.AddArgument(OptionArgumentStatics.DisableGpu);
            if (builderModel.DisableInfoBars) chromeOptions.AddArgument(OptionArgumentStatics.DisableInfoBars);
            if (builderModel.DisablePopupBlocking) chromeOptions.AddArgument(OptionArgumentStatics.DisablePopupBlocking);
            if (builderModel.Headless) chromeOptions.AddArgument(OptionArgumentStatics.Headless);
            if (builderModel.IgnoreCertificateErrors) chromeOptions.AddArgument(OptionArgumentStatics.IgnoreCertificateErrors);
            if (builderModel.Incognito) chromeOptions.AddArgument(OptionArgumentStatics.Incognito);
            if (builderModel.NoSandbox) chromeOptions.AddArgument(OptionArgumentStatics.NoSandbox);
            if (builderModel.StartMaximized) chromeOptions.AddArgument(OptionArgumentStatics.StartMaximized);

            if (builderModel.IgnoreImage) chromeOptions.AddUserProfilePreference(OptionArgumentStatics.IgnoreImage, 2);
            if (builderModel.IgnoreStylesheet) chromeOptions.AddUserProfilePreference(OptionArgumentStatics.IgnoreStylesheet, 2);

            if (ip != null)
            {
                var proxy = new Proxy
                {
                    HttpProxy = ip,
                    Kind = ProxyKind.Manual,
                    IsAutoDetect = false,
                    SslProxy = ip
                };

                chromeOptions.Proxy = proxy;
            }

            return new ChromeDriver(chromeOptions);
        }
    }
}
