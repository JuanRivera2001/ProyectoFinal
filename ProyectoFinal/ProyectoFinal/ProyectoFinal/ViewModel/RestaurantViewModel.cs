using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinal.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Plugin.Messaging;

namespace ProyectoFinal.ViewModel
{
    class RestaurantViewModel : BaseViewModel
    {
        #region Atributtes
        public int id;
        public string name;
        public string address;
        public string image;
        public string description;
        public object listViewSource;
        public bool isRefreshing = false;

        #endregion

        #region Properties
        public int IdTxt
        {
            get
            {
                return this.id;
            }
            set { SetValue(ref this.id, value); }
        }
        public string NameTxt
        {
            get
            {
                return this.name;
            }
            set { SetValue(ref this.name, value); }
        }

        public string AddressTxt
        {
            get
            {
                return this.address;
            }
            set { SetValue(ref this.address, value); }
        }

        public string ImageTxt
        {
            get
            {
                return this.image;
            }
            set { SetValue(ref this.image, value); }
        }
        public string DescriptionTxt
        {
            get
            {
                return this.description;
            }
            set { SetValue(ref this.description, value); }
        }

        public object ListViewSource
        {
            get
            {
                return this.listViewSource;
            }
            set { SetValue(ref this.listViewSource, value); }
        }

        public bool IsRefreshing
        {
            get
            {
                return this.isRefreshing;
            }
            set { SetValue(ref this.isRefreshing, value); }
        }

        #endregion

        #region Methods
        public async Task LoadList()
        {
            this.ListViewSource = await App.Db.GetTableModel<RestaurantModel>();
        }
        #endregion

        #region Constructor
        public RestaurantViewModel()
        {
            LoadList();
            IsRefreshing = false;
        }


        public RestaurantViewModel(RestaurantModel item)
        {
            NameTxt = item.RestaurantName;
            AddressTxt = item.Address;
            IdTxt = item.RestaurantId;
            ImageTxt = item.Image;
            DescriptionTxt = item.Description;
        }
        #endregion
    }
}
