using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// interfaz encargada de escribir los campos de la listas en los ficheros
    /// </summary>
    internal interface escrituraFicheroInterfaz
    {
        /// <summary>
        /// metodo que pasa la informacion de la lista bilioteca al fichero
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ecribirBiblioteca (List<BibliotecaDto> biblioteca,string ruta);
        /// <summary>
        /// metodo que pasa la informacion de la lista cliente al fichero
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ecribirCliente(List<ClienteDto> cliente, string ruta);
        /// <summary>
        /// metodo que pasa la informacion de la lista libro al fichero
        /// </summary>
        /// <param name="biblioteca"></param>
        public void ecribirLibro(List<LibroDto> libro, string ruta);
        /// <summary>
        /// metodo que pasa la informacion de la lista prestamo al fichero
        /// </summary>
        /// <param name="biblioteca"></param>
        public void escribirPrestamo(List<PrestamoDto> prestamo, string ruta);
    }
}
