using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio04Test
    {
        [TestMethod]
        public void Retorno_media_5()
        {
            //int tamanho_array = 3;
            int[] notas = new int[] { 5, 5, 5 };
            int[] peso = new int[] { 2, 3, 5 };

            Exercicio04 ex04 = new Exercicio04();

            decimal media = ex04.calcula_media(notas, peso);
            decimal esperado = 5;
            Assert.AreEqual(esperado, media);
                        
        }
        [TestMethod]
        public void Retorno_media_69()
        {
            //int tamanho_array = 3;
            int[] notas = new int[] { 7, 5, 8 };
            int[] peso = new int[] { 2, 3, 5 };

            Exercicio04 ex04 = new Exercicio04();

            decimal media = ex04.calcula_media(notas, peso);
            decimal esperado = (decimal)6.9;
            Assert.AreEqual(esperado, media);

        }

    }
}
