using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio10
    {
        public int multiplica_ate_n(int entrada)
        {
            int retorno = 0;

            for (int i = 1; i <= entrada; i++)
            {
                //Console.WriteLine(i+" X "+entrada+" = "+(i*entrada));
                retorno = i * entrada;
            }
            return retorno;

            
        }
    }
}
