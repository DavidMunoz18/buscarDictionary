using colecciones.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones.Servicios
{
    internal interface OperativaInterfaz
    {
        public void buscarCliente(Dictionary<string, ClienteDto> diccionario);
        public void darAltaCliente(Dictionary<string, ClienteDto> diccionario);
    }
}
