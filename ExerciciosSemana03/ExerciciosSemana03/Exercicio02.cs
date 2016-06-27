using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio02
    {
        public int[] Ordenar(int tamanho_array, int[] n , int tipo_de_ordem)
        {
                       
            int[] array = new int[tamanho_array];
            n.CopyTo(array, 0);
            
            int j, i;

            if (tipo_de_ordem == 1) // crescente;
            {                
                for (i = 0; i < tamanho_array; i++)
                {
                    for (j = 0; j < tamanho_array; j++)
                    {
                        if (array[j] > array[i])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }

                    }

                }

            }
            else // decrescente
            {
                for (i = 0; i < tamanho_array; i++)
                {
                    for (j = 0; j < tamanho_array; j++)
                    {
                        if (array[j] < array[i])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }

                    }

                }
            }
            
            return array;
        }
    }
}
