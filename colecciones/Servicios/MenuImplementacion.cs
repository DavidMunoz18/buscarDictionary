using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("0. cerrar");
            Console.WriteLine("1. dar alta");
            Console.WriteLine("2. buscar por nombre");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
