using System.ComponentModel;
using Xamarin.Forms;
using DrinkWater.ViewModels;

namespace DrinkWater.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}