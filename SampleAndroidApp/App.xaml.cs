using System;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace SampleAndroidApp
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceCollection services)
        {
            InitializeComponent();

            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();

            DependencyResolver.ResolveUsing(type => _serviceProvider.GetService(type));

            MainPage = _serviceProvider.GetRequiredService<MainPage>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<MainPage>();
        }
    }
}
