using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// interfaz encragada del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que recoge la eleccion del usuario
        /// </summary>
        /// <returns>un int</returns>
        public int menu();
        /// <summary>
        /// metodo que recoge la opcion de menuDarAlta
        /// </summary>
        /// <returns></returns>
        public int menuDarAlta();
    }
}
