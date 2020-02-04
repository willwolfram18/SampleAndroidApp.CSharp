using System;
using System.ComponentModel;

namespace SampleAndroidApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private int _count = 0;

        public int CurrentCount
        {
            get
            {
                return _count;
            }
            private set
            {
                OnPropertyChanging();

                _count = value;

                OnPropertyChanged();
            }
        }

        public void Increment()
        {
            CurrentCount++;
        }

        public void Decrement()
        {
            CurrentCount--;
        }
    }
}
