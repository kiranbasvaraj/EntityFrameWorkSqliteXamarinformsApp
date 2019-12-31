using EFC_SQLite_XF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EFC_SQLite_XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
