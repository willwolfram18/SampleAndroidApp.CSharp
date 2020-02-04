using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleAndroidApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            var propertyChangingArgs = new PropertyChangingEventArgs(propertyName);

            PropertyChanging?.Invoke(this, propertyChangingArgs);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var propertyChangedArgs = new PropertyChangedEventArgs(propertyName);

            PropertyChanged?.Invoke(this, propertyChangedArgs);
        }
    }
}
