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
    public partial class UserInfo : ContentPage
    {
        public UserInfo()
        {
            InitializeComponent();
            BindingContext = new UserViewModel();
        }
    }
}