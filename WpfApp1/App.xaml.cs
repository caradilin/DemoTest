using SciChart.Charting.Visuals;
using SciChart.Examples.ExternalDependencies.Controls.ExceptionView;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherUnhandledException += OnDispatcherUnhandledException;

            InitializeComponent();

            // TODO: Put your SciChart Runtime License Key here if needed
            SciChartSurface.SetRuntimeLicenseKey("Rdv7yaP+Hj+9DvcUNutMzD5IpV0drVSSkTDBYh4SeCe8iiAMnXjqvqbidFHiQX2hmMLRB7i3EuigDPK+DxDcYRISAhWN/XtggDWn2Uw3UKQ5Hhc6leIFPKKdwCLMC5JSee4OHJbqXiYHmvEuKxP/pTJ5dcR7jVNMSKJd6wIolv2YGLyuFM09jpXz1I5Kvc/76YVb4/M0jSXokkdRnorkeGB6IW+qGUZSbp5WTF7X6z85P4A4hmQQ/SNn9IkmHaOZC2x/bte7oCFcXQQRYIEFfVF8kIiq/GJHmFQl6Y0Nf/7w9kmUo0k/v0VxuSPGUD6wnSjKP002iz9JY2dkl8OHSJdQBax9awDTh3XsSrdivC/C/WbK0dH9j6ronxEkWv/3EnZZDEDMHbdz4b6C5h+tyqT7JlrLuWyRrrT+tDmV/GKIOSgvPd/n9Y4d9IhXkzn3Etepa3c1eCwVb/XxobIsTTEcEhsCzTTPo3GR3cbdjzIVsUyemXOa3JehMl8UATrFaIhKJ1+1u6oaZhEeCEABmcRXs0qXy7BtJKBj6gyrJifm6FLh4ghsL6l+5bBc/Sl41QBT0Q==");

        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            var exceptionView = new ExceptionView(e.Exception)
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };

            exceptionView.ShowDialog();

            e.Handled = true;
        }
    }

}
