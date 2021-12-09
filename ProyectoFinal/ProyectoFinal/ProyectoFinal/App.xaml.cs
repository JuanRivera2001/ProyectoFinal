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
        static DataBaseQuery database;
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

            MainPage = new NavigationPage(new Views.Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
