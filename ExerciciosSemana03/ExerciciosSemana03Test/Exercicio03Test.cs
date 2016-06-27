using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio03Test
    {
        [TestMethod]
        public void Valor_de_R()
        {
            int a = 1, b = 2, c = 3;

            Exercicio03 ex03 = new Exercicio03();

            int r = ex03.funcao_quadratica(a, b);
                       
            Assert.AreEqual(9 , r);

        }
        [TestMethod]
        public void Valor_de_S()
        {
            int a = 1, b = 2, c = 3;

            Exercicio03 ex03 = new Exercicio03();

            int s = ex03.funcao_quadratica(b, c);

            Assert.AreEqual(25, s);

        }
        [TestMethod]
        public void Valor_de_D()
        {
            int a = 1, b = 2, c = 3;

            Exercicio03 ex03 = new Exercicio03();
            int r = ex03.funcao_quadratica(a, b);
            int s = ex03.funcao_quadratica(b, c);
            float d = 4.5f;
            d = ex03.funcao_d(r, s);

            Assert.AreEqual(21.5, d);

        }

    }
}
