using ProyectoFinal707.Datos;
using ProyectoFinal707.Modelo;
using ProyectoFinal707.Vistas.MenuPrincipal;
using ProyectoFinal707.Vistas.Registro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoFinal707.VistaModelo
{
    public class VMmenuprincipal:BaseViewModel
    {
        /*
                #region VARIABLES

                #endregion

                #region CONSTRUCTOR

                #endregion

                #region OBJETOS

                #endregion

                #region PROCESOS
                #endregion

                #region COMANDOS

                #endregion
        */

        #region VARIABLES
        string identificacion;
        List<Mrecolectores> listasolRecojo;

        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Navegarmenuprincipalcommand = new Command(async () => await NavegarMenuprincipal());
            //NavegarAsignacionescomamd = new Command(async () => await Mostrarsolicitudesrecojo());
            //NavegarAsignacionescomamd = new Command<Mrecolectores>(async (f) => await NavegarAsignaciones(f));


            //NavegarAsignacionescomamd = new Command<Mrecolectores>(async (f) => await Mostrarsolicitudesrecojo());
            Mostrarsolicitudesrecojo();
        }

        #endregion

        #region OBJETOS
        public List<Mrecolectores> ListasolRecojo
        {
            get { return listasolRecojo; }
            set { SetValue(ref listasolRecojo, value); }
        }
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }


       




        #endregion

        #region PROCESOS

        private async Task NavegarMenuprincipal()
        {
            await Navigation.PushAsync(new MenuPrincipal());
        }

        private async Task Mostrarsolicitudesrecojo()
        {
            var funcion = new Drecolectores();
            ListasolRecojo = await funcion.Mostrarrecolectores();
        }
        private async Task NavegarAsignaciones(Mrecolectores parametros)
        {
            string Idsolicitud = parametros.Idrecolectores;
            VMrecolectores.idsolicitud = Idsolicitud;
            await Navigation.PushAsync(new Recolectores());
        }


        #endregion

        #region COMANDOS
        public Command Navegarmenuprincipalcommand { get; }
        public Command NavegarAsignacionescomamd { get; }
        
        #endregion

    }
}
