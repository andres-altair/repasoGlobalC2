using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// implemtacion que implementa a MenuInterfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            try
            {
                Console.WriteLine("0. cerrar");
                Console.WriteLine("1. añadir biblioteca");
                Console.WriteLine("2. acceder a una biblioteca");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                return eleccion;
            }
            catch (Exception ex) { throw; }

            
        }

        public int menuDarAlta()
        {
            try
            {
                Console.WriteLine("0. volver");
                Console.WriteLine("1. añadir usuarios");
                Console.WriteLine("2. añadir libros");
                Console.WriteLine("3. añadir prestamos");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                return eleccion;
            }
            catch (Exception ex) { throw; }
           
        }
    }
}
