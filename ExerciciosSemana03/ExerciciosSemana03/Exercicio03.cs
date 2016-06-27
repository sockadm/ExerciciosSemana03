using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio03
    {
        public int funcao_quadratica(int a, int b)
        {
            int resultado;
            // a2+2ab+b2
            resultado = ((a * a) + (2 * a * b) + (b * b));
            return resultado;
            
        }

        public float funcao_d(int r, int s)
        {
            float d = 4.5f;
            float ss = (float)s;
            float rr = (float)r;
            d = (rr + (ss / 2));

            return d;
        
        }
    }
}
