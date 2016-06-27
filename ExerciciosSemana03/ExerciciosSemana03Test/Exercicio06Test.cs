using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio06Test
    {
        [TestMethod]
        public void Espero_Reprovado()
        {
            int[] notas = new int[] { 5, 5, 5 };
            int[] peso = new int[] { 1, 1, 1 };

            Exercicio06 ex06 = new Exercicio06();

            bool aprovado = ex06.status_aprovação(notas, peso);

            Assert.AreEqual(false, aprovado);
            
        }

        [TestMethod]
        public void Espero_Aprovado()
        {
            int[] notas = new int[] { 8, 5, 9 };
            int[] peso = new int[] { 1, 1, 1 };

            Exercicio06 ex06 = new Exercicio06();

            bool aprovado = ex06.status_aprovação(notas, peso);

            Assert.AreEqual(true, aprovado);

        }
    }
}
