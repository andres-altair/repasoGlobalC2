using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Dtos
{
    internal class BibliotecaDto
    {
        long id;
        string nombre = "aaaa";
        string direccion = "aaaaa";

        public BibliotecaDto() { }
        public BibliotecaDto(long id, string nombre, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        override
        public string ToString ()
        {
            return "nombre: " + Nombre + " identificador: " + id;
        }
    }
}
