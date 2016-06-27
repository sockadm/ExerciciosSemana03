using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio14
    {
        public int fibonnaci(int elemento)
        {
            int[] serie_fibonnaci = new int[3];
            serie_fibonnaci[0] = 0;
            serie_fibonnaci[1] = 1;
            serie_fibonnaci.ToArray();
            if (elemento > 2) Array.Resize(ref serie_fibonnaci, (elemento+1)); // ajustar array para tamanho elemento;
            
            for (int i = 2; i <= elemento; i++)
            {
                serie_fibonnaci[i] = serie_fibonnaci[i - 1] + serie_fibonnaci[i - 2];
            }

            return serie_fibonnaci[elemento];

        }
    }
}
