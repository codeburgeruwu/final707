using ProyectoFinal707.Conexiones;
using ProyectoFinal707.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Firebase.Database.Query;
using System.Linq;

namespace ProyectoFinal707.Datos
{
    public class Drecolectores
    {
        public async Task<bool> InsertarRecolectores(Mrecolectores parametros)
        {
            await Constantes.firebase
                .Child("Recojo")
                .PostAsync(new Mrecolectores()
                {
                    Correo = parametros.Correo,
                    Estado = parametros.Estado,
                    Identificacion = parametros.Identificacion,
                    Nombre = parametros.Nombre
                    

                });
            return true;
        }
        public async Task<List<Mrecolectores>> Buscarrecolectores(Mrecolectores parametrosPedir)
        {
            return (await Constantes.firebase
                .Child("Recojo")
                .OrderByKey()
                .OnceAsync<Mrecolectores>())
                .Where(a => a.Object.Identificacion == parametrosPedir.Identificacion)
                .Where(b => b.Object.Estado == "Activo")
                .Select(item => new Mrecolectores
                {
                    Idrecolectores = item.Key,
                    Nombre = item.Object.Nombre,
                    Correo = item.Object.Correo
                }).ToList();
        }

       public async Task<List<Mrecolectores>> Mostrarrecolectores()
        {
            return (await Constantes.firebase
                .Child("Recojo")
                .OrderByKey()
                .OnceAsync<Mrecolectores>())
                .Where(a => a.Object.Estado == "Activo")
                .Select(item => new Mrecolectores
                {
                    Idrecolectores = item.Key,
                    Identificacion = item.Object.Identificacion,    
                    Nombre = item.Object.Nombre,
                    Correo = item.Object.Correo

                }).ToList();
        }


    }
}
