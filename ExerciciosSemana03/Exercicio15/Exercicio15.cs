using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio15_console;

namespace Exercicio15
{
    class Exercicio15
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            ConsoleOpcoes ex15 = new ConsoleOpcoes();
            int quit = 1;

            while (quit != 0)
            {


                int opcao = ex15.console_listar();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Qual o nome do item a ser inserido: ");
                        lista.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Informe o item procurado: ");
                        string procurado = Console.ReadLine();
                        if (lista.Find(x => lista.Contains(procurado)) == null) Console.WriteLine("Item não encontrado");
                        else Console.WriteLine(lista.Find(x => lista.Contains(procurado)));
                        ex15.aperte_para_continuar();            
                        break;
                    case 3:
                        Console.WriteLine("Total de items = " + lista.Count);
                        ex15.aperte_para_continuar();
                        break;
                    case 4:
                        lista.Sort(); //ordena para facilitar a exclusão
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Qual item deseja excluir?");
                        lista.Remove(Console.ReadLine());
                        ex15.aperte_para_continuar();
                        break;
                    case 0:
                        //Console.WriteLine("Sair do programa");
                        quit = 0;
                        break;
                    default:

                        break;
                }

            }

            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Lista Final de itens:");
            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            ex15.aperte_para_continuar();

        }


    }

    
}

