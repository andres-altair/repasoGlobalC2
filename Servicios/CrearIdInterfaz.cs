using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// interfaz que se encarga de crear los id 
    /// </summary>
    internal interface CrearIdInterfaz
    {
        /// <summary>
        /// metodo que crea el id para la biblioteca
        /// </summary>
        /// <param name="biblioteca"></param>???que pongo
        /// <returns>un long </returns>??? que pongo
        public long crearIdBiblioteca(List<BibliotecaDto> biblioteca);
        /// <summary>
        /// metodo que crea un id paar el cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>un long</returns>
        public long crearIdCliente(List<ClienteDto> cliente);
        /// <summary>
        /// metodo que crea un id paea el libro
        /// </summary>
        /// <param name="libro"></param>
        /// <returns>un long</returns>
        public long crearIdLibro (List<LibroDto> libro);    
        /// <summary>
        /// metodo que crea un id para el prestamo
        /// </summary>
        /// <param name="prestamo"></param>
        /// <returns> un long</returns>
        public long crearIdPrestamo(List<PrestamoDto> prestamo);
    }
}
