using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio09
    {
        public int soma_negativos(int[] entrada)
        {
            int soma_neg = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i]<0)
                {
                    soma_neg = entrada[i] + soma_neg;
                }
            }

            return soma_neg;
        }
    }
}
