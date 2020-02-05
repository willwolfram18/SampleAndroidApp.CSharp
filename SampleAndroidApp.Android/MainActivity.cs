using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Internals;
using Microsoft.Extensions.DependencyInjection;
using SampleAndroidApp.Services;
using SampleAndroidApp.Droid.Services;
using SampleAndroidApp.Services.Logging;
using SampleAndroidApp.Droid.Services.Logging;
using Android.Content;

namespace SampleAndroidApp.Droid
{
    [Activity(Label = "SampleAndroidApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            var services = new ServiceCollection();

            ConfigureServices(services);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(services));

            var intent = new Intent(ApplicationContext, typeof(SimpleBackgroundService));
            StartService(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStop()
        {
            var intent = new Intent(ApplicationContext, typeof(SimpleBackgroundService));

            StopService(intent);

            base.OnStop();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IToastr, ToastrService>()
                .AddTransient(typeof(IWriteLog<>), typeof(Logger<>));
        }
    }
}