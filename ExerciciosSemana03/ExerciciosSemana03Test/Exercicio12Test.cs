using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio12Test
    {
        [TestMethod]
        public void Retorna_matriz_inversa()
        {
            int[] entrada = new int[] { 5, 321, 8, 238, 321, 865, 2, -52, 304 };
            int[] esperado = new int[entrada.Length];
            entrada.CopyTo(esperado, 0);
            Array.Reverse(esperado);
            int[] saida = new int[entrada.Length];

            Exercicio12 ex12 = new Exercicio12();

            saida = ex12.inverte_matriz(entrada);

            CollectionAssert.AreEqual(esperado, saida);
        }
    }
}
