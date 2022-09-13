using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_custo_viagem_com_SQLITE.View;

namespace App_custo_viagem_com_SQLITE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Lista());
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
