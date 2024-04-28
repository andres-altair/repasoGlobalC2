using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal1Casa.Dtos
{
    internal class LibroDto
    {
        long id;
        long idBiblioteca;
        string titulo = "aaaaaa";
        string subtitulo = "aaaaa";
        string autor = "aaaaa";
        string ISBN = "aaaaa";
        int numeroEdicion = 9999999;
        string editorial = "aaaaaa";
        int stock = 99999;

        public LibroDto() { }   
        public LibroDto(long id,string titulo, string subtitulo, string autor, string iSBN, int numeroEdicion, string editorial, int stock)
        {
            this.id = id;
            this.idBiblioteca = Program.identificadorBiblioteca;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.autor = autor;
            ISBN = iSBN;
            this.numeroEdicion = numeroEdicion;
            this.editorial = editorial;
            this.stock = stock;
        }

        public LibroDto(long id, long idBiblioteca, string titulo, string subtitulo, string autor, string iSBN, int numeroEdicion, string editorial, int stock)
        {
            this.id = id;
            this.idBiblioteca = idBiblioteca;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.autor = autor;
            ISBN = iSBN;
            this.numeroEdicion = numeroEdicion;
            this.editorial = editorial;
            this.stock = stock;
        }

        public long Id { get => id; set => id = value; }
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
