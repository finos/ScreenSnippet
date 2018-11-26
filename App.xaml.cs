using Paragon.Plugins.ScreenCapture;
using System;
using System.Linq;
using System.Windows;

namespace ScreenSnippet
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string[] availableLocale = { "en-US", "ja-JP", "fr-FR" };

            string filename = (e.Args.Length >= 1 && !string.IsNullOrEmpty(e.Args[0])) ? e.Args[0] : null;
            string locale = (e.Args.Length == 2 && !string.IsNullOrEmpty(e.Args[1])) ? e.Args[1] : null;

            if (filename != null)
            {
                if (locale != null && availableLocale.Contains(locale))
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(locale);
                }
                SnippingWindow win = new SnippingWindow(filename);
                win.Show();
            }
            else
            {
                throw new Exception("Missing filename command line argument.");
            }
        }
    }
}
