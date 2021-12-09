using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotifications;
using ProyectoFinal.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgetPassword : ContentPage
    {
        public ForgetPassword()
        {
            //Send the confirm code on a local notification
            InitializeComponent();
            BindingContext = new ForgetPasswordViewModel();
            CrossLocalNotifications.Current.Show("RestaurantApp", "Código de confirmación: 75846");
        }
    }
}