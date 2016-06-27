using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciciosSemana03;

namespace ExerciciosSemana03Test
{
    [TestClass]
    public class Exercicio05Test
    {
        [TestMethod]
        public void Retorna_10_segundos()
        {
            int entrada = 10;
            int hora = 0, min = 0, seg = 10;
            Exercicio05 ex05 = new Exercicio05();

            string saida = ex05.converte_segundos_para_hora(entrada);
            string esperado = (hora + ":" + min + ":" + seg);

            Assert.AreEqual(esperado, saida);
        
        }

        [TestMethod]
        public void Retorna_1_minuto_10_segundos()
        {
            int entrada = 70;
            int hora = 0, min = 1, seg = 10;
            Exercicio05 ex05 = new Exercicio05();

            string saida = ex05.converte_segundos_para_hora(entrada);
            string esperado = (hora + ":" + min + ":" + seg);

            Assert.AreEqual(esperado, saida);

        }
        [TestMethod]
        public void Retorna__1_hora_1_minuto_10_segundos()
        {
            int entrada = 3670;
            int hora = 1, min = 1, seg = 10;
            Exercicio05 ex05 = new Exercicio05();

            string saida = ex05.converte_segundos_para_hora(entrada);
            string esperado = (hora + ":" + min + ":" + seg);

            Assert.AreEqual(esperado, saida);

        }

        [TestMethod]
        public void Retorna__4_hora_52_minuto_40_segundos()
        {
            int entrada = 17560;
            int hora = 4, min = 52, seg = 40;
            Exercicio05 ex05 = new Exercicio05();

            string saida = ex05.converte_segundos_para_hora(entrada);
            string esperado = (hora + ":" + min + ":" + seg);

            Assert.AreEqual(esperado, saida);

        }
    }
}
