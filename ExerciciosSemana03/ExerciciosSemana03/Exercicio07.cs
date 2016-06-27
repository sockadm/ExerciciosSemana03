using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana03
{
    public class Exercicio07
    {
        public string calcula_grupo(int idade)
        {
            string retorno;

            if (idade < 5)
            {
                retorno = "Idade menor que 5";
            }
            else if (idade <= 7)
            {
                retorno = "Infantil A";
            }
            else if (idade <= 10)
            {
                retorno = "Infantil B";
            }
            else if (idade <= 13)
            {
                retorno = "Juvenil A";
            }
            else if (idade <= 17)
            {
                retorno = "Juvenil B";
            }
            else
            {
                retorno = "Adulto";
            }


            return retorno;
        }
    }
}
