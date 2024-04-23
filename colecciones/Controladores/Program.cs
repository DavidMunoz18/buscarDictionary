using colecciones.Dtos;
using colecciones.Servicios;
using System.ComponentModel;

namespace colecciones
{
    class program
    {
        public static void Main(String[] args)
        {
            Dictionary<string, ClienteDto> diccionario = new Dictionary<string, ClienteDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrar = false;
            int opcion;
            while(!cerrar)
            {
                opcion = mi.mostrarMenuYSeleccion();
                switch(opcion)
                {
                    case 0:
                        cerrar = true;
                        break;
                    case 1:
                        oi.darAltaCliente(diccionario);
                        break;
                    case 2:
                        oi.buscarCliente(diccionario);
                        break;
                }
            }

           

        }
    }
}
