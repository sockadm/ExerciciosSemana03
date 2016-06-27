using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio08Test
    {
        [TestMethod]
        public void Retorna_min_1_max_10()
        {
            int tamanho_array = 2; // min posicao 0 e max posicao 1;
            int[] n = new int[] { 82, 45, 18, 100, 4, 35, 567, -5 }; //8 posicoes
            int[] esperado = new int[] { -5, 567 };
            int[] menor = new int[tamanho_array];
            Exercicio08 ex08 = new Exercicio08();

            menor = ex08.retorna_min_max(n.Length, n);

            CollectionAssert.AreEquivalent(esperado, menor);
        }
        [TestMethod]
        public void Retorna_min_1_max_10_12posicoes()
        {
            int tamanho_array = 2; // min posicao 0 e max posicao 1;
            int[] n = new int[] { 82, 45, 18, 100, -54, 35, 5067, -5,35,789,234,334 }; //12 posicoes
            int[] esperado = new int[] { -54, 5067 };
            int[] menor = new int[tamanho_array];
            Exercicio08 ex08 = new Exercicio08();

            menor = ex08.retorna_min_max(n.Length, n);

            CollectionAssert.AreEquivalent(esperado, menor);
        }
    }
}
