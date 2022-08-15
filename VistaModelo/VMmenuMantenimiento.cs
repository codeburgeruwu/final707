using ProyectoFinal707.Vistas.MenuPrincipal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ProyectoFinal707.Vistas.Registro;
namespace ProyectoFinal707.VistaModelo
{
    public class VMmenuMantenimiento:BaseViewModel
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTOR
        public VMmenuMantenimiento(INavigation navigation)
        {
            Navigation = navigation;
            //Volvercomamd = new Command(async () => await Volver());
            NavegarRecolectoresconfigcomamd = new Command(async () => await Navegarrecolectores());
        }
        #endregion

        #region OBJETOS

        #endregion

        #region PROCESOS
        private async void NavegarMenumantenimiento()
        {
            await Navigation.PushAsync(new MenuMantenimiento());
        }

        private async void NavegarMenuPrincipal()
        {
            //await Navigation.PushAsync(new MenuPrincipal());
            await Navigation.PopAsync();
        }

        private async Task Navegarrecolectores()
        {
            await Navigation.PushAsync(new Recolectores());
        }


        //private async Task Volver()
        //{
        //    await Navigation.PopAsync();
        //}
        #endregion

        #region COMANDOS
        public ICommand Navegarmenumantenimientocommand => new Command(NavegarMenumantenimiento);
        public ICommand Volvercomamd => new Command(NavegarMenuPrincipal);
        
        public Command NavegarRecolectoresconfigcomamd { get; }
        
        //public ICommand Volvercomamd { get; }
        #endregion
    }
}
