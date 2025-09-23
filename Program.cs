using System;
using TDEMarkao;

class Program
{


    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        int opc = 0;
        do
        {


            opc = menuLib();

            switch (opc)
            {
                case 1:
                    biblioteca.RegistrarLivro();
                    Pausar();
                    break;
                case 2:
                    biblioteca.ListaLivros();
                    Pausar();
                    break;

                case 3:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Pausar();

                    break;
            }

        } while (opc != 3);

    }
    static int menuLib()
    {
        Console.Clear();
        Console.WriteLine("===========================================");
        Console.WriteLine("Bem-Vindo ao Sistema de Cadastro de Livros, selecione uma opção: \n");
        Console.WriteLine("1 - Registrar Livro");
        Console.WriteLine("2 - Exibir Livros");
        Console.WriteLine("3 - Sair");
        Console.WriteLine("===========================================");
        Console.Write("Digite sua opção: ");
        if (int.TryParse(Console.ReadLine(), out int opcao))
            return opcao;
        return -1;


    }
    static void Pausar()
    {
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
}