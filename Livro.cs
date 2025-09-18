using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TDEMarkao
{

    public class Livro
    {
        private string titulo;
        private string autor;
        private string dataPub;
        private string categoria;
        private int numPagina;

        public Livro() { }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string DataPub { get => dataPub; set => dataPub = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int NumPagina { get => numPagina; set => numPagina = value; }




        public void ExibirLivro()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Data de Publicação: {DataPub}");
            Console.WriteLine($"Categoria: {Categoria}");
            Console.WriteLine($"Número de Páginas: {NumPagina}");
        }



    }
}


