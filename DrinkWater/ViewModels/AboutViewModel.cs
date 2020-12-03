using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DrinkWater.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            //Title = "About";
            //TODO Add proper Address for privacy policy
            OpenWebCommand = new Command(async () => await Browser.OpenAsync(""));
        }

        public ICommand OpenWebCommand { get; }
    }
}