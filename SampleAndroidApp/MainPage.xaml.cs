using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleAndroidApp.ViewModels;
using Xamarin.Forms;

namespace SampleAndroidApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; }

        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainPageViewModel();
            BindingContext = ViewModel;
        }

        public void IncreaseCount(object sender, EventArgs e)
        {
            ViewModel.Increment();
        }

        public void DecreaseCount(object sender, EventArgs e)
        {
            ViewModel.Decrement();
        }
    }
}
