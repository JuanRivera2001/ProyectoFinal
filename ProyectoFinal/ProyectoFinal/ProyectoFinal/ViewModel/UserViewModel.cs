using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ProyectoFinal.Models;
using ProyectoFinal.Views;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    class UserViewModel : BaseViewModel
    {
        #region Atributos
        public string user = "";
        public string password = "";
        public string confirmPassword = "";
        public string name = "";
        public string email = "";
        public string phoneNumber = "";
        #endregion



        #region Prop

        public string UserTxt
        {
            get
            {
                return this.user;
            }
            set { SetValue(ref this.user, value); }
        }
        public string PasswordTxt
        {
            get
            {
                return this.password;
            }
            set { SetValue(ref this.password, value); }
        }

        public string ConfirmPasswordTxt
        {
            get
            {
                return this.confirmPassword;
            }
            set { SetValue(ref this.confirmPassword, value); }
        }

        public string EmailTxt
        {
            get
            {
                return this.email;
            }
            set { SetValue(ref this.email, value); }
        }

        public string NameTxt
        {
            get
            {
                return this.name;
            }
            set { SetValue(ref this.name, value); }
        }

        public string PhoneNumberTxt
        {
            get
            {
                return this.phoneNumber;
            }
            set { SetValue(ref this.phoneNumber, value); }
        }
        #endregion


        #region Commands

        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
            set { }
        }

        #endregion


        #region Methods

        public async void RegisterMethod()
        {
            //Check that the password and confirmation password are the same, and check that all the fields are fill
            if (password != confirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error","Las contraseñas no coinciden", "OK");
            }
            else if(user.Equals("") || password.Equals("") || email.Equals("") || phoneNumber.Equals("") || name.Equals(""))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Ingrese todos los datos para registrarse", "OK");
            }
            else
            {
                //In case that pass the validations the user is create
                var userMod = new UserModel();
                userMod.Name = name;
                userMod.User = user;
                userMod.Password = password;
                userMod.Email = email;
                userMod.PhoneNumber = phoneNumber;
                await App.Db.SaveUserModelAsync(userMod);

                await Application.Current.MainPage.DisplayAlert("Registro", name + ", se ha registrado exitosamente!!", "OK");
                await Application.Current.MainPage.Navigation.PushAsync(new Login());
            }
        }

        #endregion

    }
}
