using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// implementacion que implementa a escrituraFicheroInterfaz
    /// </summary>
    internal class escrituraFicheroImplementacion : escrituraFicheroInterfaz
    {
        public void ecribirBiblioteca(List<BibliotecaDto> biblioteca, string ruta)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                BibliotecaDto bibliotecaDto = new BibliotecaDto();
                foreach (BibliotecaDto b in biblioteca)
                {
                    sw.WriteLine(b.Id + ";" + b.Nombre + ";" + b.Direccion);
                }
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
           
        }

        public void ecribirCliente(List<ClienteDto> cliente, string ruta)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                ClienteDto clienteDto = new ClienteDto();
                foreach (ClienteDto c in cliente)
                {
                    sw.WriteLine(c.Id + ";" + c.IdBiblioteca + ";" + c.Nombre + ";" + c.Apellidos + ";" + c.Nacimiento + ";" + c.Dni + ";" + c.IdBiblioteca + ";" + c.CorreoElectronico + ";" + c.InicioSuspension + ";" + c.FinSuspension);
                }
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
        }

        public void ecribirLibro(List<LibroDto> libro, string ruta)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                LibroDto libroDto = new LibroDto();
                foreach (LibroDto l in libro)
                {
                    sw.WriteLine(l.Id + ";" + l.IdBiblioteca + ";" + l.Titulo + ";" + l.Subtitulo + ";" + l.Autor + ";" + l.ISBN1 + ";" + l.NumeroEdicion + ";" + l.Editorial + ";" + l.Stock);
                }
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
        }

        public void escribirPrestamo(List<PrestamoDto> prestamo, string ruta)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                PrestamoDto prestamoDto = new PrestamoDto();
                foreach (PrestamoDto p in prestamo)
                {
                    sw.WriteLine(p.Id + ";" + p.IdBiblioteca + ";" + p.IdentificadorCliente + ";" + p.IdentificadorLibro + ";" + p.FchPrestamo + ";" + p.FchEntrega + ";" + p.EstadoPrestamo);
                }
                sw.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
           
        }
    }
}
