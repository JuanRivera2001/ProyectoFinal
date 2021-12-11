using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.ViewModel;
using ProyectoFinal.Models;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantList : ContentPage
    {
        public RestaurantList()
        {
            InitializeComponent();
            BindingContext = new RestaurantViewModel();
        }

        private void ListV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Restaurants(e.SelectedItem as RestaurantModel));
        }
    }
}