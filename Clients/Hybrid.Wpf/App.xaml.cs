using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace Hybrid.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            Resources.Add("services", Services);
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Services.GetRequiredService<MainWindow>().Show();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainWindow>();

            serviceCollection.AddWpfBlazorWebView();

#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif

            return serviceCollection.BuildServiceProvider();

        }
    }
}
