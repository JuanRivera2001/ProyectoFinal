using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Models;
using ProyectoFinal.Views;

namespace ProyectoFinal.ViewModel
{
    class LateralMenuFlyoutViewModel : BaseViewModel
    {
        #region Att
        public string icon;
        public string title = "RestaurantApp";
        public object listViewSource;

        #endregion

        #region Prop

        public string Icon
        {
            get
            {
                return this.icon;
            }
            set { SetValue(ref this.icon, value); }
        }


        public string Title
        {
            get
            {
                return this.title;
            }
            set { SetValue(ref this.title, value); }
        }




        public object ListViewSource
        {
            get
            {
                return this.listViewSource;
            }
            set { SetValue(ref this.listViewSource, value); }
        }


        #endregion

        #region Metodos
        public async Task LoadList()
        {
            this.ListViewSource = new List<LateralMenuModel>(new[]
                {
                    new LateralMenuModel { Id = 0, Title = "Inicio" , Icon = "LogoApertura.png" , TargetType = typeof(Home)},
                    new LateralMenuModel { Id = 1, Title = "Restaurantes ", Icon = "LogoApertura.png" , TargetType = typeof(Restaurants) },
                    new LateralMenuModel { Id = 2, Title = "Mi perfil ", Icon = "usr.png" , TargetType = typeof(UserInfo) },
                    

                });


        }

        #endregion

        #region Constructor
        public LateralMenuFlyoutViewModel()
        {
            LoadList();

        }
        #endregion
    }
}
