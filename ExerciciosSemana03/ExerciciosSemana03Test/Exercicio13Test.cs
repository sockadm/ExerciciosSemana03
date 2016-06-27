using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio13Test
    {
        [TestMethod]
        public void Retorna_vetor_par()
        {
            int[] entrada = new int[] { 5, 321, 8, 238, 321, 865, 2, -52, 304 };
            int[] esperado = new int[] { 8, 238, 2, -52, 304 };
            int[] saida_par = new int[entrada.Length];
            int tipo = 1;
            Exercicio13 ex13 = new Exercicio13();

            saida_par = ex13.retorna_vetor_par_ou_impar(entrada,tipo); //tipo 1 par e tipo 2 impar

            CollectionAssert.AreEqual(esperado, saida_par);


        }
        [TestMethod]
        public void Retorna_vetor_impar()
        {
            int[] entrada = new int[] { 5, 321, 8, 238, 321, 865, 2, -52, 304 };
            int[] esperado = new int[] { 5, 321, 321, 865 };
            int[] saida_par = new int[entrada.Length];
            int tipo = 2;
            Exercicio13 ex13 = new Exercicio13();

            saida_par = ex13.retorna_vetor_par_ou_impar(entrada, tipo); //tipo 1 par e tipo 2 impar

            CollectionAssert.AreEqual(esperado, saida_par);


        }
    }
}
