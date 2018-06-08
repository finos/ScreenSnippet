using Paragon.Plugins.ScreenCapture;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace ScreenSnippet
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string[] availableLocale = { "en-US", "ja-JP" };
            // mandatory filename arg - grabbed output will write to this file.
            if (e.Args.Length == 1 && !string.IsNullOrEmpty(e.Args[0]))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                string filename = e.Args[0];
                SnippingWindow win = new SnippingWindow(filename);
                win.Show();
            }
            else if (e.Args.Length == 2 && !string.IsNullOrEmpty(e.Args[0]) && !string.IsNullOrEmpty(e.Args[1]))
            {
                string filename = e.Args[0];
                string localeTag = e.Args[1];

                // validate the localeTag with the availableLocale
                if (availableLocale.Contains(localeTag))
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(localeTag);
                }
                else
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
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
