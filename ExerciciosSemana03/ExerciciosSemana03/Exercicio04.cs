using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio04
    {
        public decimal calcula_media(int[] notas, int[] peso)
        {
            decimal media = 0, soma = 0;
            //media = 0;
            //soma = 0;
            int tamanho_array, i, soma_peso = 0;
            tamanho_array = notas.Length;

            for (i = 0; i < tamanho_array; i++)
            {
                soma = soma +(notas[i] * peso[i]);
                soma_peso = peso[i] + soma_peso;
                
            }
            media = soma / soma_peso;
            Math.Round((decimal)media, 3);
            return media; 
        }
    }
}
