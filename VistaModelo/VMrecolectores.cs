using Firebase.Auth;
using ProyectoFinal707.Conexiones;
using ProyectoFinal707.Datos;
using ProyectoFinal707.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoFinal707.VistaModelo
{
    public class VMrecolectores : BaseViewModel
    {

        #region VARIABLES
        string txtnombre;
        string txtcorreo;
        string txtidentificacion;
        string txtcontraseña;

        string idrecolector;
        public static string idsolicitud;
        string txtnombreRecolector;

        #endregion

        #region CONSTRUCTOR
        public VMrecolectores(INavigation navigation)
        {
            Navigation = navigation;
            Insertarcomamd = new Command(async () => await InsertarRecolectores());
            Volvercomamd = new Command(async () => await Volver());
            Buscarcommand = new Command(async () => await BuscarRecolectores());

        }
        #endregion
        #region OBJETOS 
        public string Txtcontraseña
        {
            get { return txtcontraseña; }
            set { SetValue(ref txtcontraseña, value); }
        }
        public string Txtnombre
        {
            get { return txtnombre; }
            set { SetValue(ref txtnombre, value); }
        }
        public string Txtidentificacion
        {
            get { return txtidentificacion; }
            set { SetValue(ref txtidentificacion, value); }
        }
        public string Txtcorreo
        {
            get { return txtcorreo; }
            set { SetValue(ref txtcorreo, value); }
        }

        //aca

        public string Idrecolector
        {
            get { return idrecolector; }
            set { SetValue(ref idrecolector, value); }
        }
        public string TxtnombreRecolector
        {
            get { return txtnombreRecolector; }
            set { SetValue(ref txtnombreRecolector, value); }
        }

        #endregion
        #region PROCESOS
        private async Task Volver()
        {
            await Navigation.PopAsync();
        }
        private async Task InsertarRecolectores()
        {
            var funcion = new Drecolectores();
            var parametros = new Mrecolectores();
            parametros.Nombre = Txtnombre;
            parametros.Identificacion = Txtidentificacion;
            parametros.Correo = Txtcorreo;
            parametros.Estado = "Activo";
            var estadofuncion = await funcion.InsertarRecolectores(parametros);
            if (estadofuncion == true)
            {
                await CrearCorreo(Txtcorreo, Txtcontraseña);
            }
        }
        private async Task CrearCorreo(string correo, string contraseña)
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(Constantes.WebapyFirebase));
            await authProvider.CreateUserWithEmailAndPasswordAsync(correo, contraseña);
            await DisplayAlert("Estado", "Registro creado", "OK");
        }

        private async Task BuscarRecolectores()
        {
            var funcion = new Drecolectores();
            var parametros = new Mrecolectores();
            parametros.Identificacion = Txtidentificacion;
            var lista = await funcion.Mostrarrecolectores();
            foreach (var data in lista)
            {
                Txtnombre = data.Nombre;
                Txtidentificacion=data.Identificacion;
                Txtcorreo = data.Correo;
            }
        }


        #endregion

        #region COMANDOS
        public Command Insertarcomamd { get; }
        public Command Volvercomamd { get; }
        public Command Buscarcommand { get; }

        #endregion

    }
}
