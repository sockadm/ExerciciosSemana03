using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio11
    {
        public int[] copia_vetor(int[] entrada)
        {
            int[] retorno = new int[entrada.Length];

            for (int i = 0; i < entrada.Length; i++)
            {
                retorno[i] = entrada[i];
            }

            return retorno;
        }
    }
}
