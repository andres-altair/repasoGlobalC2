using ejercicioGlobal1Casa.Dtos;
using ejercicioGlobal1Casa.Servicios;

namespace ejercicioGlobal1Casa
{
    class Program
    {
        public static long identificadorBiblioteca;
        public static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            string ruta = "C:\\Users\\andre\\OneDrive\\Escritorio\\"+hoy.ToString("yyyyMMdd")+ "log.txt";
            string rutaB = "C:\\Users\\andre\\OneDrive\\Escritorio\\" + hoy.ToString("yyyyMMdd") + "log.txt"+"\\"+"biblioteca";
            List<BibliotecaDto> biblioteca = new List<BibliotecaDto>();
            List<ClienteDto>clienteDtos = new List<ClienteDto>();
            List<LibroDto>libro = new List<LibroDto>();
            List<PrestamoDto>prestamo = new List<PrestamoDto>();
            MenuInterfaz mi = new MenuImplementacion();
            DarAltaInterfaz di = new DarAltaImplementacion();
            Aceso a  = new Aceso();
            escrituraFicheroInterfaz ei = new escrituraFicheroImplementacion();
            LecturaFicherosInterfaz lf = new LecturaFicherosImplementacion();
            lf.ficheroBliblioteca(biblioteca,ruta);
            lf.ficheroCliente(clienteDtos,ruta);
            lf.ficheroLibro(libro,ruta);
            lf.ficheroPrestamo(prestamo,ruta);
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
                            
                                ei.ecribirBiblioteca(biblioteca, ruta);
                           
                                ei.ecribirCliente(clienteDtos, ruta);

                                ei.ecribirLibro(libro, ruta);

                                ei.escribirPrestamo(prestamo, ruta);
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
                
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
            

        }
    }
}