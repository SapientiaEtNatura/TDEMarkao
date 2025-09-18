using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDEMarkao;

namespace TDEMarkao
{
    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void RegistrarLivro()
        {
            Livro novoLivro = new Livro();
            Console.WriteLine("Digite o título do livro:");
            novoLivro.Titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor do livro:");
            novoLivro.Autor = Console.ReadLine();
            Console.WriteLine("Digite a data de publicação do livro:");
            novoLivro.DataPub = Console.ReadLine();
            Console.WriteLine("Digite a categoria do livro:");
            novoLivro.Categoria = Console.ReadLine();
            Console.WriteLine("Digite o número de páginas do livro:");
            int paginas;
            while (!int.TryParse(Console.ReadLine(), out paginas) || paginas <= 0)
            {
                Console.WriteLine("Número Inválido, tente novamente:");
            }
            novoLivro.NumPagina = paginas;
            livros.Add(novoLivro);
            Console.WriteLine("Livro registrado com sucesso!");
        }

        public void ListaLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }
            foreach (var livro in livros)
            {
                livro.ExibirLivro();
                Console.WriteLine("-----------------------");
            }
        }







    }
}
