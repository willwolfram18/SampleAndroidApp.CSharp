using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleAndroidApp.Services;
using SampleAndroidApp.ViewModels;
using Xamarin.Forms;

namespace SampleAndroidApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly IToastr _toastr;

        public MainPage(IToastr toastr)
        {
            InitializeComponent();

            _toastr = toastr;

            ViewModel = new MainPageViewModel();
            BindingContext = ViewModel;
        }

        public MainPageViewModel ViewModel { get; }


        public void IncreaseCount(object sender, EventArgs e)
        {
            ViewModel.Increment();

            _toastr.Show($"Count increased to {ViewModel.CurrentCount}.");
        }

        public void DecreaseCount(object sender, EventArgs e)
        {
            ViewModel.Decrement();

            _toastr.Show($"Count decreased to {ViewModel.CurrentCount}.");
        }
    }
}
