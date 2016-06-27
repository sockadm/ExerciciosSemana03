using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio02Test
    {
        [TestMethod]
        public void N1_menor_retorna_N1()
        {
            int tamanho_array = 3;
            int[] n = new int[] { 82, 45, 18 };
            int[] arrumado = new int[] { 18, 45, 82 };
            int[] menor = new int[tamanho_array]; 
            Exercicio02 ex02 = new Exercicio02();

            menor = ex02.Ordenar(3,n,1);

            CollectionAssert.AreEquivalent(arrumado, menor);

        }

        [TestMethod]
        public void N2_menor_retorna_N2()
        {
            int tamanho_array = 3;
            int[] n = new int[] { 5, 3, 8 };
            int[] arrumado = new int[] { 3, 5, 8 };
            int[] menor = new int[tamanho_array];
            Exercicio02 ex02 = new Exercicio02();

            menor = ex02.Ordenar(3, n, 1);

            CollectionAssert.AreEquivalent(arrumado, menor);

        }

        [TestMethod]
        public void N3_menor_retorna_N3()
        {
            int tamanho_array = 3;
            int[] n = new int[] { 5, 3, 1 };
            int[] arrumado = new int[] { 1, 3, 5 };
            int[] menor = new int[tamanho_array];
            Exercicio02 ex02 = new Exercicio02();

            menor = ex02.Ordenar(3, n, 1);

            CollectionAssert.AreEquivalent(arrumado, menor);

        }

        [TestMethod]
        public void Retorna_ordem_decrescente()
        {
            int tamanho_array = 5;
            int[] n = new int[] { 5, 1, 3, 8, 9 };
            int[] arrumado = new int[] { 9, 8, 5, 3, 1 };
            int[] menor = new int[tamanho_array];
            Exercicio02 ex02 = new Exercicio02();

            menor = ex02.Ordenar(tamanho_array, n, 2);

            CollectionAssert.AreEquivalent(arrumado, menor);

        }
    }
}
