using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio06
    {
        public bool status_aprovação(int[] notas, int[] peso)
        {
            
            Exercicio04 ex06 = new Exercicio04();
            decimal media = ex06.calcula_media(notas, peso);
            if (media >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
