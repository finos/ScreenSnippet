using Paragon.Plugins.ScreenCapture;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace ScreenSnippet
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // mandatory filename arg - grabbed output will write to this file.
            if (e.Args.Length == 1 && !string.IsNullOrEmpty(e.Args[0]))
            {
                string filename = e.Args[0];
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
