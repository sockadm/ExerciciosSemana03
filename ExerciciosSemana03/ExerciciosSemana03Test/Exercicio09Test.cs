using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio09Test
    {
        [TestMethod]
        public void Soma_negativos_20()
        {
            int[] entrada = new int[] { 10, 20, 30, 40, -10, -5, -1, -4 };
            int esperado = -20;

            Exercicio09 ex09 = new Exercicio09();

            int saida = ex09.soma_negativos(entrada);

            Assert.AreEqual(esperado, saida);
            
        }
        [TestMethod]
        public void Soma_negativos_90()
        {
            int[] entrada = new int[] { 10, 20, -30, -40, -10, -5, -1, -4 };
            int esperado = -90;

            Exercicio09 ex09 = new Exercicio09();

            int saida = ex09.soma_negativos(entrada);

            Assert.AreEqual(esperado, saida);

        }
    }
}
