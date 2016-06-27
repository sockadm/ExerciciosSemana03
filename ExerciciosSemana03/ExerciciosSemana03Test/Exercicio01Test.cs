using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio01Test
    {
        [TestMethod]
        public void N1_menor_retorna_N1()
        {
            int[] n = new int[] { 1, 5, 8 };
           
            Exercicio01 ex01 = new Exercicio01();

            int menor = ex01.acharmenor(3,n);

            Assert.AreEqual(1, menor);

        }

        [TestMethod]
        public void N2_menor_retorna_N2()
        {
            int[] n = new int[] { 10, 5, 8 };

            Exercicio01 ex01 = new Exercicio01();

            int menor = ex01.acharmenor(3, n);

            Assert.AreEqual(5, menor);

        }

        [TestMethod]
        public void N3_menor_retorna_N3()
        {
            int[] n = new int[] { 10, 55, 8 };

            Exercicio01 ex01 = new Exercicio01();

            int menor = ex01.acharmenor(3, n);

            Assert.AreEqual(8, menor);

        }
    }
}
