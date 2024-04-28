using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// interfaz que se encaraga de dar alta 
    /// </summary>
    internal interface DarAltaInterfaz
    {
        /// <summary>
        /// metodo que registra  a una biblioteca
        /// </summary>
        /// <param name="biblioteca"></param>
        public void darAltaBiblioteca(List<BibliotecaDto> biblioteca);
        /// <summary>
        /// metodo que registra a un usuario
        /// </summary>
        /// <param name="cliente"></param>
        public void darAltaCliente(List<ClienteDto> cliente);
        /// <summary>
        /// metodo que registra a un libro
        /// </summary>
        /// <param name="cliente"></param>
        public void darAltaLibro(List<LibroDto> libro);
        /// <summary>
        /// metodo que registra a un prestamo
        /// </summary>
        /// <param name="cliente"></param>
        public void darAltaPrestamo(List<PrestamoDto> prestamo);
    }
}
