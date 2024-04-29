using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// implementacion que implementa a CrearIdInterfaz
    /// </summary>
    internal class CrearIdImplemtacion : CrearIdInterfaz
    {

        public long crearIdBiblioteca(List<BibliotecaDto> biblioteca)
        {

            long id = 0;
            int tamañoLista  = biblioteca.Count;
            if(tamañoLista > 0)
            {
                id = biblioteca[tamañoLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public long crearIdCliente(List<ClienteDto> cliente)
        {
            long id = 0;
            int tamañoLista = cliente.Count;
            if (tamañoLista > 0)
            {
                id = cliente[tamañoLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public long crearIdLibro(List<LibroDto> libro)
        {
            long id = 0;
            int tamañoLista = libro.Count;
            if (tamañoLista > 0)
            {
                id = libro[tamañoLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public long crearIdPrestamo(List<PrestamoDto> prestamo)
        {
            long id = 0;
            int tamañoLista = prestamo.Count;
            if (tamañoLista > 0)
            {
                id = prestamo[tamañoLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
    }
}
