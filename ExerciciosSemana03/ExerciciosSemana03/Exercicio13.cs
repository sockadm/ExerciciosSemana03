using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio13
    {
        public int[] retorna_vetor_par_ou_impar(int[] entrada, int tipo)
        {
            int cont_par = 0 , cont_impar = 0;      
            int[] retorno_par = new int[entrada.Length];

            int[] retorno_impar = new int[entrada.Length];

            for (int i = 0; i < entrada.Length; i++)
            {                
                if ((entrada[i] % 2) == 0)
                {
                    
                    retorno_par[cont_par] = entrada[i];
                    cont_par++;
                }
                else
                {
                    retorno_impar[cont_impar] = entrada[i];
                    cont_impar++;
                }

            }

            retorno_par.ToArray();
            Array.Resize(ref retorno_par, cont_par); //ajusta o tamanho do vetor para a qtd de itens que existem nele.
            retorno_impar.ToArray();
            Array.Resize(ref retorno_impar, cont_impar);


            if (tipo == 1)
            {
                return retorno_par;
            }
            else 
            {
                return retorno_impar;
            }
        }
    }
}
