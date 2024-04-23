using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones.Dtos
{
    internal class ClienteDto
    {
        long id;
        string nombre = "aaaaa";
        string dni = "aaaaa";
        int edad = 11111;
        string estudios = "aaaaa";

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Estudios { get => estudios; set => estudios = value; }

        public ClienteDto()
        {
        }

        public ClienteDto(string nombre, string dni, int edad, string estudios)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
            this.estudios = estudios;
        }
    }
}
