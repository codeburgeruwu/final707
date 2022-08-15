using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinal707.Vistas.MenuPrincipal;
using ProyectoFinal707.VistaModelo;

namespace ProyectoFinal707.Vistas.MenuPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMantenimiento : ContentPage
    {
        public MenuMantenimiento()
        {
            InitializeComponent();
            BindingContext = new VMmenuMantenimiento(Navigation);

        }
    }
}