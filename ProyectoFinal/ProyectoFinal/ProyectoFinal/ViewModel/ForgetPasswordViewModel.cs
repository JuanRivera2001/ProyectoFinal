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
    class ForgetPasswordViewModel : BaseViewModel
    {
        #region Atributos
        public string email;
        public string confirmCode;
        public string newPassword;
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
        public string ConfirmCodeTxt
        {
            get
            {
                return this.confirmCode;
            }
            set { SetValue(ref this.confirmCode, value); }
        }

        public string NewPasswordTxt
        {
            get
            {
                return this.newPassword;
            }
            set { SetValue(ref this.newPassword, value); }
        }
        #endregion


        #region Commands

        //Command that execute the Recovery Method
        public ICommand RecoveryCommand
        {
            get
            {
                return new RelayCommand(RecoveryMethod);
            }
            set { }
        }

        #endregion


        #region Methods
        //Execute the Task of DataBaseQuery class
        public async void RecoveryMethod()
        {

            List<UserModel> ListUser = App.Db.ChangeUserPassword(email, confirmCode, newPassword).Result;

            UserModel Usr = App.Db.GetUserModel(email, newPassword).Result;

            await Application.Current.MainPage.DisplayAlert("Cambio contraseña", "Su contraseña se ha cambiado exitosamente!", "OK");
            await Application.Current.MainPage.Navigation.PushAsync(new Login());

        }
        #endregion
    }
}
