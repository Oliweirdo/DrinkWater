using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DrinkWater.Models;
using DrinkWater.Views;
using DrinkWater.ViewModels;

namespace DrinkWater.Views
{
    public partial class SettingsPage : ContentPage
    {


        public SettingsPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}