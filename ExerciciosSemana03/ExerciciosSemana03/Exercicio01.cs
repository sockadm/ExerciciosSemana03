using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio01
    {
        public int acharmenor(int tamanho_array,int[] n)
        {

            int menor;
            int[] array = new int[tamanho_array];
            n.CopyTo(array, 0);

            for (int i = 0; i < tamanho_array; i++)
            {
                for (int j = 0; j < tamanho_array; j++)
                {
                    if (array[j]>array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
            menor = array[0];
            return menor;
        }
    }
}
