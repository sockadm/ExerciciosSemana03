using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosSemana03;

namespace ExerciciosSemana03
{
    public class Exercicio08
    {
        public int[] retorna_min_max(int tamanho_array, int[] n)
        {
            int[] array = new int[tamanho_array];
            int[] retorno = new int[2];

            Exercicio02 ex02 = new Exercicio02();
            array = ex02.Ordenar(tamanho_array, n, 1);
            retorno[0] = array[0];
            retorno[1] = array[tamanho_array - 1];

            return retorno;
        }
    }
}
