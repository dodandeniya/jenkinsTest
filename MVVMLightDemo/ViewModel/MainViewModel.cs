using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MVVMLightDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string textVal = "Change me";

        public MainViewModel()
        {
            OnTextChangeButtonClickedCommand = new RelayCommand(OnTextChangeButtonClickedHandler);
        }

        public string TextVal
        {
            get { return textVal; }
            set { Set(() => TextVal, ref textVal, value); }
        }

        public RelayCommand OnTextChangeButtonClickedCommand { get; private set; }

        private void OnTextChangeButtonClickedHandler()
        {
            TextVal = "Hello MVVM light.";
            i
        }
    }
}