using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio14Test
    {
        [TestMethod]
        public void Retorno_0()
        {
            int elemento = 0;
            int esperado = 0;

            Exercicio14 ex14 = new Exercicio14();

            int saida = ex14.fibonnaci(elemento);

            Assert.AreEqual(esperado, saida);
           
            
        }

        [TestMethod]
        public void Retorno_1()
        {
            int elemento = 1;
            int esperado = 1;

            Exercicio14 ex14 = new Exercicio14();

            int saida = ex14.fibonnaci(elemento);

            Assert.AreEqual(esperado, saida);


        }
        [TestMethod]
        public void Retorno_5()
        {
            int elemento = 5;
            int esperado = 5;

            Exercicio14 ex14 = new Exercicio14();

            int saida = ex14.fibonnaci(elemento);

            Assert.AreEqual(esperado, saida);
            
        }
        [TestMethod]
        public void Retorno_89()
        {
            int elemento = 11;
            int esperado = 89;

            Exercicio14 ex14 = new Exercicio14();

            int saida = ex14.fibonnaci(elemento);

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorno_2584()
        {
            int elemento = 18;
            int esperado = 2584;

            Exercicio14 ex14 = new Exercicio14();

            int saida = ex14.fibonnaci(elemento);

            Assert.AreEqual(esperado, saida);

        }
    }
}
