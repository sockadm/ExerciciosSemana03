using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio12
    {
        public int[] inverte_matriz(int[] entrada)
        {
            int[] retorno = new int[entrada.Length];
            for (int i = 0; i < entrada.Length; i++)
            {
                //int temp = entrada[i];
                retorno[i] = entrada[entrada.Length - (i + 1)];

            }
            return retorno;
        }
    }
}
