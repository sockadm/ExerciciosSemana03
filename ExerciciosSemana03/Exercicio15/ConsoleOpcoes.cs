using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15_console

{
    public class ConsoleOpcoes
    {
        internal int console_listar()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|(1) - Inserir item           |");
            Console.WriteLine("|(2) - Buscar itens           |");
            Console.WriteLine("|(3) - Total item             |");
            Console.WriteLine("|(4) - Excluir item           |");
            Console.WriteLine("|(0) - Sair do programa       |");
            Console.WriteLine("-------------------------------");
            Console.Write("Informe a opção desejada: ");
            int saida = Convert.ToInt32(Console.ReadLine());
            return saida;
        }

        internal void aperte_para_continuar()
        {
            Console.WriteLine("Aperte uma tecla para continuar");
            Console.ReadKey();
        }
    }
}
