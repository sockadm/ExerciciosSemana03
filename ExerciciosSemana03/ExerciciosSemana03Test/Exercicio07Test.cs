using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio07Test
    {
        [TestMethod]
        public void Retorna_Menor_que_5()
        {
            int idade = 3;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Idade menor que 5";

            Assert.AreEqual(esperado, saida);
                        
        }
        [TestMethod]
        public void Retorna_Infantil_A()
        {
            int idade = 5;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Infantil A";

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna_Infantil_B()
        {
            int idade = 9;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Infantil B";

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna_Juvenil_A()
        {
            int idade = 13;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Juvenil A";

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna_Juvenil_B()
        {
            int idade = 17;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Juvenil B";

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna_Adulto()
        {
            int idade = 18;

            Exercicio07 ex07 = new Exercicio07();

            string saida = ex07.calcula_grupo(idade);
            string esperado = "Adulto";

            Assert.AreEqual(esperado, saida);

        }

    }
}
