using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoFinal707.VistaModelo;
namespace ProyectoFinal707.Vistas.Registro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recolectores : ContentPage
    {
        public Recolectores()
        {
            InitializeComponent();
            BindingContext = new VMrecolectores(Navigation);
        }
    }
}