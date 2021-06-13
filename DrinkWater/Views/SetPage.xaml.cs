using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkWater.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetPage : ContentPage
    {
            public SetPage()
        {
            InitializeComponent();
        }
        
        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
          
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {

        }

        private void half_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void one_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void onehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
        private void two_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void twohalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void three_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void threehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
        private void four_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        }
    }
}