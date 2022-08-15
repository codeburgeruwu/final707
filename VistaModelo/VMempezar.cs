using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using ProyectoFinal707.VistaModelo;
using ProyectoFinal707.Vistas.MenuPrincipal;

using Xamarin.Forms;

namespace ProyectoFinal707
{
    public class VMempezar : BaseViewModel
    {
        #region VARIABLES

        #endregion
        #region CONSTRUCTOR
        public VMempezar(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS

        #endregion
        
        #region PROCESOS
        private async void NavegarMenuprincipal()
        {
            await Navigation.PushAsync(new MenuPrincipal());
        }
        #endregion
        
        #region COMANDOS
        public ICommand Navegarmenuprincipalcommand => new Command(NavegarMenuprincipal);
        #endregion
    }
}
