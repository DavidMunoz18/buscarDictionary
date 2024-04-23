using colecciones.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void buscarCliente(Dictionary<string, ClienteDto> diccionario)
        {

            Console.WriteLine("Introduzca el nombre");
            string nombreUsu = Console.ReadLine();

            ClienteDto cliente = diccionario[nombreUsu];

              Console.WriteLine(cliente.Nombre.ToString());
              Console.WriteLine(cliente.Dni.ToString());
              Console.WriteLine(cliente.Edad.ToString());
              Console.WriteLine(cliente.Estudios.ToString());

        }

        public void darAltaCliente(Dictionary<string, ClienteDto> diccionario)
        {
           
            ClienteDto cliente = crearCliente();

            diccionario.Add(cliente.Nombre, cliente);
        }
        private ClienteDto crearCliente()
        {

   

            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Introduzca el nombre");
            cliente.Nombre = Console.ReadLine();


            Console.WriteLine("Introduzca el dni");
            cliente.Dni = Console.ReadLine();

            Console.WriteLine("Introduzca el edad");
            cliente.Edad = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Introduzca tus estudios");
            cliente.Estudios = Console.ReadLine();

            
            return cliente;
        }
    }
}
