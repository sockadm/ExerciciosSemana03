using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio11Test
    {
        [TestMethod]
        public void Retorna_matriz_copia()
        {
            int[] entrada = new int[] { 5, 321, 8, 238, 23, 7, 89, 235, 211, 87 };
            int[] esperado = new int[] { 5, 321, 8, 238, 23, 7, 89, 235, 211, 87 };
            int[] saida = new int[entrada.Length];

            Exercicio11 ex11 = new Exercicio11();

            saida = ex11.copia_vetor(entrada);

            CollectionAssert.AreEqual(esperado, saida);

        }
    }
}
