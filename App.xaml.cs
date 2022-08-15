using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinal707.Vistas.Registro;
namespace ProyectoFinal707
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Empezar();
            MainPage = new NavigationPage(new Empezar());
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
