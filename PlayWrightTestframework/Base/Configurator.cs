
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PlayWrightTestframework.Base
{
    // Sonstige Configuration über die RunSettings
    public class Configurator : MyPageTest
    {
        private  string URL { get; set; }
        private Size BrowserSize { get; set; }

        





        public Configurator()  : base(){ GetConfig(); }
        private void GetConfig()
        {

            XDocument xdoc = XDocument.Load("C:\\Users\\Thomas\\source\\repos\\PlayWrightTestframework\\PlayWrightTestframework\\test.runsettings");

            var url = xdoc.Descendants("webAppUrl").First().Value;
            
            if (url.Equals(null) || url.Equals("")) throw new ArgumentNullException("Fehlende Konfiguration der URL");
            this.URL = url.ToString();

            var x = xdoc.Descendants("BrowserSizeX").First().Value;
            var y = xdoc.Descendants("BrowserSizeY").First().Value;
            if (x.Equals(null) || y.Equals(null) || x.Equals("") || y.Equals("")) throw new ArgumentNullException("Fehlende Konfiguration der Browsersize");
            BrowserSize = new Size(int.Parse(x), int.Parse(y));

 
            Console.WriteLine("Konfiguration geladen");
        }

        [TestInitialize]
        public void TestInitialize()
        {
             Page.GotoAsync(URL);
        }
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                ColorScheme = ColorScheme.Light,
                ViewportSize = new()
                {
                    Width = BrowserSize.Width,
                    Height = BrowserSize.Height
                },
                BaseURL = URL,
            };
        }
    }
}
