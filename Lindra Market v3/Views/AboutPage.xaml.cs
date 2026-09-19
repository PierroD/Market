using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Lindra_Market_v3.Utils;

namespace Lindra_Market_v3.Views
{
    public partial class AboutPage : Page
    {
        private static readonly string Version = AppVersionHelper.Version;
        private const string GithubUrl = "https://github.com/PierroD/Market";
        private const string ReportIssueUrl = "https://github.com/PierroD/Market/issues/new";
        private const string FaqUrl = "https://github.com/PierroD/Market/blob/main/_readmes/FAQ.md";

        public AboutPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            HeroVersionText.Text = Version;
            SysOsText.Text = RuntimeInformation.OSDescription;
            SysArchText.Text = RuntimeInformation.ProcessArchitecture.ToString();
            SysRuntimeText.Text = RuntimeInformation.FrameworkDescription;
        }

        private void OnVisitGithubClick(object sender, RoutedEventArgs e)
        {
            OpenUrl(GithubUrl);
        }

        private void OnReportIssueClick(object sender, RoutedEventArgs e)
        {
            OpenUrl(ReportIssueUrl);
        }

        private void OnVisitFaqClick(object sender, RoutedEventArgs e)
        {
            OpenUrl(FaqUrl);
        }

        private async void OnCopySystemInfoClick(object sender, RoutedEventArgs e)
        {
            string systemInfo = $"""
Lindra Market {Version}
OS: {RuntimeInformation.OSDescription}
Architecture: {RuntimeInformation.ProcessArchitecture}
Runtime: {RuntimeInformation.FrameworkDescription}
UI: WPF-UI v4.2.1
""";

            Clipboard.SetText(systemInfo);

            CopySystemInfoButton.SetResourceReference(ContentControl.ContentProperty, "About_System_Copied");
            await Task.Delay(1500);
            CopySystemInfoButton.SetResourceReference(ContentControl.ContentProperty, "About_System_CopyBtn");
        }

        private void Page_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (PageScrollViewer.ScrollableHeight > 0)
            {
                PageScrollViewer.ScrollToVerticalOffset(PageScrollViewer.VerticalOffset - e.Delta * 0.5);
                e.Handled = true;
            }
        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                // Fallback safely if default browser cannot be invoked
            }
        }
    }
}
