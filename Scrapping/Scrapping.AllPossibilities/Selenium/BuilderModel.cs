namespace Scrapping.AllPossibilities.Selenium
{
    /// <summary>
    /// Chrome builder model
    /// </summary>
    public class BuilderModel
    {
        public bool NoSandbox { get; set; }
        public bool StartMaximized  { get; set; }
        public bool IgnoreImage { get; set; }
        public bool IgnoreStylesheet { get; set; }
        public bool IgnoreCertificateErrors { get; set; }
        public bool Incognito { get; set; }
        public bool DisablePopupBlocking { get; set; }
        public bool Headless{ get; set; }
        public bool DisableExtensions { get; set; }
        public bool DisableGpu { get; set; }
        public bool DisableInfoBars { get; set; }
    }
}
