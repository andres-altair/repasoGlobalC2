using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Dtos
{
    internal class ClienteDto
    {
        long id;
        long idBiblioteca;
        string nombre = "aaaaa";
        string apellidos = "aaaaaa";
        DateTime nacimiento = new DateTime(9999, 12, 31);
        string dni = "aaaaaa";
        string correoElectronico = "aaaaaa";
        DateTime inicioSuspension = new DateTime(9999, 12, 31);
        DateTime finSuspension = new DateTime(9999, 12, 31);

        public ClienteDto() { }

        public ClienteDto(long id, string nombre, string apellidos, DateTime nacimiento, string dni, string correoElectronico)
        {
            this.id = id;
            this.idBiblioteca = Program.identificadorBiblioteca;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nacimiento = nacimiento;
            this.dni = dni;
            this.correoElectronico = correoElectronico;
            this.inicioSuspension = inicioSuspension;
            this.finSuspension = inicioSuspension.AddDays(8);
        }

        public ClienteDto(long id, long idBiblioteca, string nombre, string apellidos, DateTime nacimiento, string dni, string correoElectronico, DateTime inicioSuspension, DateTime finSuspension)
        {
            this.id = id;
            this.idBiblioteca = idBiblioteca;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nacimiento = nacimiento;
            this.dni = dni;
            this.correoElectronico = correoElectronico;
            this.inicioSuspension = inicioSuspension;
            this.finSuspension = finSuspension;
        }

        public long Id { get => id; set => id = value; }
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Dni { get => dni; set => dni = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime InicioSuspension { get => inicioSuspension; set => inicioSuspension = value; }
        public DateTime FinSuspension { get => finSuspension; set => finSuspension = value; }
    }
}
