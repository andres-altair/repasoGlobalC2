using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// implementacion que implementa a DarAltaInterfaz
    /// </summary>
    internal class DarAltaImplementacion : DarAltaInterfaz
    {
        CrearIdInterfaz ci  =new CrearIdImplemtacion();
        public void darAltaBiblioteca(List<BibliotecaDto> biblioteca)
        {
            try
            {
                long id = ci.crearIdBiblioteca(biblioteca);
                Console.WriteLine("escribe el nombre de la biblioteca");
                string nombre = Console.ReadLine();
                Console.WriteLine("escribe la direccion de la biblioteca");
                string direccion = Console.ReadLine();
                BibliotecaDto bibliotecaDto = new BibliotecaDto(id, nombre, direccion);
                biblioteca.Add(bibliotecaDto);
                foreach(BibliotecaDto b in biblioteca)
                {
                    Console.WriteLine(b.ToString());
                }

            }
            catch (Exception ex) { throw; }
            
        }

        public void darAltaCliente(List<ClienteDto> cliente)
        {
            try
            {
                long id = ci.crearIdCliente(cliente);
                Console.WriteLine("escribe tu nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("escribe tu apellido");
                string apellido = Console.ReadLine();
                Console.WriteLine("escribe tu fecha de nacimiento (yyyy-MM-dd )");
                DateTime fchNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("escribe tu dni");
                string dni = DNI();
                Console.WriteLine("escribe tu correo electronico");
                string correoElectronico = Console.ReadLine();
                ClienteDto clienteDto = new ClienteDto(id, nombre, apellido, fchNacimiento, dni, correoElectronico);
                cliente.Add(clienteDto);

            }
            catch (Exception ex) { throw; }
            
        }
        /// <summary>
        /// metodo que comprueba que ets bien el dni
        /// </summary>
        /// <returns></returns>
        private string DNI()
        {
            try
            {
                char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                int dniNum = 1;
                char letra = 'a';
                bool comprobante = false;
                while (!comprobante)
                {
                    Console.WriteLine("Dame el dni(Numero)");
                    dniNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el dni(Letra en mayuscula)");
                    letra = Convert.ToChar(Console.ReadLine());

                    int resto = dniNum % 23;
                    if (letras[resto] == letra)
                    {
                        comprobante = true;
                    }
                    else
                    {
                        comprobante = false;
                    }

                }
                string dni = dniNum + "" + letra;
                return dni;
            }
            catch (Exception ex) { throw; }    
            
        }

        public void darAltaLibro(List<LibroDto> libro)
        {
            try
            {
                long id = ci.crearIdLibro(libro);
                Console.WriteLine("escribe el titulo ");
                string titulo = Console.ReadLine();
                Console.WriteLine("escribe el subtitulo");
                string subtitulo = Console.ReadLine();
                Console.WriteLine("escribe el nombre del autor");
                string autor = Console.ReadLine();
                Console.WriteLine("escribe el ISBN");
                string ISBN = Console.ReadLine();
                Console.WriteLine("escribe el numero de edicion");
                int numEdicion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("escribe la editorial");
                string editorial = Console.ReadLine();
                Console.WriteLine("escribe el stock");
                int stock = Convert.ToInt32(Console.ReadLine());
                LibroDto libroDto = new LibroDto(id, titulo, subtitulo, autor, ISBN, numEdicion, editorial, stock);
                libro.Add(libroDto);


            }
            catch (Exception ex) { throw; }
           
        }

        public void darAltaPrestamo(List<PrestamoDto> prestamo)
        {
            try
            {
                long id = ci.crearIdPrestamo(prestamo);
                Console.WriteLine("escribe el identicador del cliente");
                long idCliente = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("escribe el identificador del libro ");
                long idLibro = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("el estado del prestamo");
                string estadoPrestamo = Console.ReadLine();
                PrestamoDto prestamoDto = new PrestamoDto(id, idCliente, idLibro, estadoPrestamo);
                prestamo.Add(prestamoDto);
            }
            catch (Exception ex) { throw; }
           

        }
    }
}
