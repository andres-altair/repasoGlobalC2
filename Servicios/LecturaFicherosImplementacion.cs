using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// implementacion que implementa a LecturaFicherosInterfaz
    /// </summary>
    internal class LecturaFicherosImplementacion : LecturaFicherosInterfaz
    {
        
        public void ficheroBliblioteca(List<BibliotecaDto> biblioteca, string ruta)
        {
            
            try
            {
                if (File.Exists(ruta))
                {

                    StreamReader sr = new StreamReader(ruta);
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(';');
                        BibliotecaDto bibliotecaDto = new BibliotecaDto(Convert.ToInt64(campos[0]), campos[1], campos[2]);
                        biblioteca.Add(bibliotecaDto);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
           
        }
        public void ficheroCliente(List<ClienteDto> cliente, string ruta)
        {
            
            try
            {
                if (File.Exists(ruta))
                {
                    StreamReader sr = new StreamReader(ruta);
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(';');
                        ClienteDto clienteDto = new ClienteDto
                        {
                            Id = Convert.ToInt64(campos[0]),
                            IdBiblioteca = Convert.ToInt64(campos[1]),
                            Nombre = campos[2],
                            Apellidos = campos[3],
                            Nacimiento = Convert.ToDateTime(campos[4]),
                            Dni = campos[5],
                            CorreoElectronico = campos[6],
                            InicioSuspension = Convert.ToDateTime(campos[7]),
                            FinSuspension = Convert.ToDateTime(campos[8])
                        };
                        cliente.Add(clienteDto);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
           
            
        }

        public void ficheroLibro(List<LibroDto> libro, string ruta)
        {
            
            try
            {
                if (File.Exists(ruta))
                {
                    string[] linea = File.ReadAllLines(ruta);
                    foreach (string line in linea)
                    {
                        string[] campos = line.Split(";");
                        LibroDto libroDto = new LibroDto(Convert.ToInt64(campos[0]), Convert.ToInt64(campos[1]), campos[2], campos[3], campos[4], campos[5], Convert.ToInt32(campos[6]), campos[7], Convert.ToInt32(campos[8]));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
            
            
        }

        public void ficheroPrestamo(List<PrestamoDto> prestamo, string ruta)
        {
            
            try
            {
                if (File.Exists(ruta))
                {
                    string linea;
                    StreamReader sr = new StreamReader(ruta);
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] campo = linea.Split(',');
                        PrestamoDto prestamoDto = new PrestamoDto
                        {
                            Id = Convert.ToInt64(campo[0]),
                            IdBiblioteca = Convert.ToInt64(campo[1]),
                            IdentificadorCliente = Convert.ToInt64(campo[2]),
                            IdentificadorLibro = Convert.ToInt64(campo[3]),
                            FchPrestamo = Convert.ToDateTime((campo[4])),
                            FchEntrega = Convert.ToDateTime((campo[5])),
                            EstadoPrestamo = campo[6]
                        };
                        prestamo.Add(prestamoDto);
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("error al conectarse con los ficheros");
            }
            
        }
    }
}
