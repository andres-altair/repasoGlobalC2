using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// interfaz encargada de leer los ficheros y guradarlos en las lista
    /// </summary>
    internal interface LecturaFicherosInterfaz
    {

        /// <summary>
        /// metodo que lee y guarda la informacacion hacia la lista BibliotecaDto
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ficheroBliblioteca(List<BibliotecaDto> biblioteca,string ruta);
        /// <summary>
        /// metodo que lee y guarda la informacacion hacia la lista ClienteDto
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ficheroCliente(List<ClienteDto> cliente, string ruta);
        /// <summary>
        /// metodo que lee y guarda la informacacion hacia la lista LibroDto
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ficheroLibro(List<LibroDto> libro, string ruta);
        /// <summary>
        /// metodo que lee y guarda la informacacion hacia la lista PrestamoDto
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ficheroPrestamo(List<PrestamoDto> prestamo, string ruta);
    }
}
