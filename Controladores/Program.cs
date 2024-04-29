using ejercicioGlobal1Casa.Dtos;
using ejercicioGlobal1Casa.Servicios;

namespace ejercicioGlobal1Casa
{
    /// <summary>
    /// clase principal
    /// </summary>
    class Program
    {
        public static long identificadorBiblioteca;
        public static DateTime hoy = DateTime.Now;
        public static string rutaLog = "C:\\Users\\andre\\OneDrive\\Escritorio\\" + hoy.ToString("yyyyMMdd") + "-log.txt";
        /// <summary>
        /// metodo principal
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
          
            
            string rutaB = "C:\\Users\\andre\\OneDrive\\Escritorio\\biblioteca";
            string rutaC = "C:\\Users\\andre\\OneDrive\\Escritorio\\cliente" ;
            string rutaL = "C:\\Users\\andre\\OneDrive\\Escritorio\\libro";
            string rutaP = "C:\\Users\\andre\\OneDrive\\Escritorio\\prestamo";
            List<BibliotecaDto> biblioteca = new List<BibliotecaDto>();
            List<ClienteDto>clienteDtos = new List<ClienteDto>();
            List<LibroDto>libro = new List<LibroDto>();
            List<PrestamoDto>prestamo = new List<PrestamoDto>();
            MenuInterfaz mi = new MenuImplementacion();
            DarAltaInterfaz di = new DarAltaImplementacion();
            Aceso a  = new Aceso();
            escrituraFicheroInterfaz ei = new escrituraFicheroImplementacion();
            LecturaFicherosInterfaz lf = new LecturaFicherosImplementacion();
            lf.ficheroBliblioteca(biblioteca,rutaB);
            lf.ficheroCliente(clienteDtos,rutaC);
            lf.ficheroLibro(libro,rutaL);
            lf.ficheroPrestamo(prestamo,rutaP);
            bool abrir = false;
            int eleccion;
            int eleccion2;
            try
            {
                while (!abrir)
                    {
                        eleccion = mi.menu();
                        switch (eleccion)
                        {
                            case 0:
                            
                                ei.ecribirBiblioteca(biblioteca, rutaB);
                           
                                ei.ecribirCliente(clienteDtos, rutaC);

                                ei.ecribirLibro(libro, rutaL);

                                ei.escribirPrestamo(prestamo, rutaP);
                            Console.WriteLine("cerrado");
                                abrir = true;
                                break;
                            case 1:  di.darAltaBiblioteca(biblioteca);
                                break;
                            case 2:
                                if (biblioteca.Count > 0)
                                {
                                    a.acceso(biblioteca);
                                    eleccion2 = mi.menuDarAlta();
                                    switch (eleccion2)
                                    {
                                        case 0:
                                            Console.WriteLine("volver");
                                            break;
                                        case 1:
                                            di.darAltaCliente(clienteDtos);
                                            break;
                                        case 2:
                                            di.darAltaLibro(libro);
                                            break;
                                        case 3:
                                            di.darAltaPrestamo(prestamo);
                                            break;
                                        default:
                                            Console.WriteLine("eleecion no reconocida");
                                            break;
                                    }
                                }
                                else { Console.WriteLine("no hay biblioteca"); }
                                break;
                            default: Console.WriteLine("eleccion bo reconocida ");
                                break;
                        }
                    }
                
            }catch (Exception ex) 
            { Console.WriteLine("ha habido un error, intentelo mas tarde"); 
             StreamWriter sw = new StreamWriter(rutaLog);
                sw.WriteLine(ex.ToString());
                sw.Close();
            }
            
            

        }
    }
}