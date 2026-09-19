using System;
using System.Windows;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppSettingsManager.Initialize();
        }
    }
}
