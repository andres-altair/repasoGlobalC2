using ejercicioGlobal1Casa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Servicios
{
    /// <summary>
    /// clase que da acceso a una biblioteca
    /// </summary>
    internal class Aceso
    {
        /// <summary>
        /// metodo que da valor a  Program.identificadorBiblioteca 
        /// </summary>
        /// <param name="bibliotecaDtos"></param>
        public void acceso(List<BibliotecaDto> bibliotecaDtos)
        {
            try
            {
                List<long> l = new List<long>();
                BibliotecaDto biblioteca = new BibliotecaDto();
                foreach (BibliotecaDto b in bibliotecaDtos)
                {
                    l.Add(b.Id);
                    Console.WriteLine(b.ToString());
                }
                long identificador;
                do
                {
                    Console.WriteLine("Dame el identifivador para verificar a que biblioteca quieres acceder");
                    identificador = Int32.Parse(Console.ReadLine());
                } while (!l.Contains(identificador));
                Program.identificadorBiblioteca = identificador;
            }
            catch (Exception ex) { throw; }
            
        }
    }
}
