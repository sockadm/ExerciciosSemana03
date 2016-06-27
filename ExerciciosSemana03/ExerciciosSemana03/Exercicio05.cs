using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio05
    {
        public string converte_segundos_para_hora(int entrada)
        {

            int hora = entrada / 3600;
            int min = ((entrada - (hora * 3600)) / 60);
            int seg = entrada % 60;
            string saida = (hora + ":" + min + ":" + seg);
            return saida;

        }
    }
}
