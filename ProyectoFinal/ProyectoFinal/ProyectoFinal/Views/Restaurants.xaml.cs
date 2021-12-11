using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.ViewModel;
using ProyectoFinal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Restaurants
    {
        public Restaurants()
        {
            InitializeComponent();
            BindingContext = new RestaurantViewModel();
        }

        public Restaurants(RestaurantModel item)
        {
            InitializeComponent();
            BindingContext = new RestaurantViewModel(item);
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}