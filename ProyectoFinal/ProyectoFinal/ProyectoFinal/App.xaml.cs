using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinal.Views;
using ProyectoFinal.DataBase;
using ProyectoFinal.Models;
using System.IO;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public partial class App : Application
    {   
        //Generic initialization of database
        static DataBaseQuery database;
        public static string email;
        public static string password;
        public static DataBaseQuery Db
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBUnidad3.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            //Set the login view as Main Page of application
            MainPage = new NavigationPage(new Views.Login());
        }

        protected override void OnStart()
        {
            //Code used to load the information of teh restaurants in the list
            //RestaurantModel rest = new RestaurantModel();
            //rest.RestaurantId = 0;
            //rest.RestaurantName = "Ambar";
            //rest.Address = "Cl 14 #18-18, Pereira";
            //rest.Image = "AmbarLogo.png";
            //rest.Description = "En Ambar nos destacamos por ser un Restaurante de alta cocina contemporánea," +
            //                    " en donde nuestra técnica principal es la técnica al vacío, ofrecemos para nuestros" +
            //                    " comensales platos inspirados en la cocina europea, con sabores acompañados de una amplia" +
            //                    " gama de cócteles y vinos para disfrutar.";

            //RestaurantModel rest1 = new RestaurantModel();
            //rest1.RestaurantId = 1;
            //rest1.RestaurantName = "La Lucerna";
            //rest1.Address = "Calle 19 6-43, Pereira";
            //rest1.Image = "LucernaLogo.png";
            //rest1.Description = "Desde hace más de 60 años LUCERNA ha logrado exitosamente todo un mundo de sabores " +
            //                    "y experiencias para nuestro paladar.";

            //RestaurantModel rest2 = new RestaurantModel();
            //rest2.RestaurantId = 2;
            //rest2.RestaurantName = "Keizaki";
            //rest2.Address = "Carrera 15 Bis # 5-25, Pereira";
            //rest2.Image = "KeizakiLogo.png";
            //rest2.Description = "En KEIZAKI SUSHI & WOK contamos con la creatividad de nuestros Chefs, y " +
            //                    "el buen gusto y opiniones de nuestros clientes que combinados conforman el " +
            //                    "mejor equipo para desarrollar las mejores preparaciones y variedades. ";

            //var resul = Db.SaveModelAsync<RestaurantModel>(rest, true);
            //var resul1 = Db.SaveModelAsync<RestaurantModel>(rest1, true);
            //var resul2 = Db.SaveModelAsync<RestaurantModel>(rest2, true);

            //List<RestaurantModel> ListRest = Db.GetTableModel<RestaurantModel>().Result;

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
