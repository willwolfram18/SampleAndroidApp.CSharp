using System;
using Android.App;
using Android.Widget;
using SampleAndroidApp.Droid.Services;
using SampleAndroidApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(ToastrService))]
namespace SampleAndroidApp.Droid.Services
{
    public class ToastrService : IToastr
    {
        public ToastrService()
        {
        }

        public void Show(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}
