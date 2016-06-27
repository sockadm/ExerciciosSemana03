using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio10Test
    {
        [TestMethod]
        public void Retorna_1()
        {
            int entrada = 1;
            int esperado = 1;

            Exercicio10 ex10 = new Exercicio10();

            int saida = ex10.multiplica_ate_n(entrada);

            Assert.AreEqual(esperado, saida);
            
        }
        [TestMethod]
        public void Retorna_25()
        {
            int entrada = 5;
            int esperado = 25;

            Exercicio10 ex10 = new Exercicio10();

            int saida = ex10.multiplica_ate_n(entrada);

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna_36()
        {
            int entrada = 6;
            int esperado = 36;

            Exercicio10 ex10 = new Exercicio10();

            int saida = ex10.multiplica_ate_n(entrada);

            Assert.AreEqual(esperado, saida);

        }

    }
}
