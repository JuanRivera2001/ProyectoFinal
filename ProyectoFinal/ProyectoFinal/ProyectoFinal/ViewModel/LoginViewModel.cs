using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ProyectoFinal.Models;
using ProyectoFinal.Views.MaestroDetalle;
using Xamarin.Forms;
using ProyectoFinal.Views;

namespace ProyectoFinal.ViewModel
{
    class LoginViewModel : BaseViewModel
    {

        #region Atributos
        public string email;
        public string password;
        #endregion


        #region Prop

        public string EmailTxt
        {
            get
            {
                return this.email;
            }
            set { SetValue(ref this.email, value); }
        }
        public string PasswordTxt
        {
            get
            {
                return this.password;
            }
            set { SetValue(ref this.password, value); }
        }

        #endregion


        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }
            set { }
        }

        #endregion


        #region Methods

        //Send the credentials taken from the login View and check if the user exist in DB
        public async void LoginMethod()
        {

            List<UserModel> ListUser = App.Db.ValidateUserModel(email, password).Result;

            UserModel Usr = App.Db.GetUserModel(email, password).Result;


            if (ListUser.Count > 0)
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido", "Bienvenido a RestaurantApp ", "OK");
                App.email = email;
                App.password = password;
                await Application.Current.MainPage.Navigation.PushAsync(new LateralMenu());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", "Usuario o contraseña incorrecta.", "OK");
            }
        }

        #endregion



    }
}
