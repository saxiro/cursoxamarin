using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bogus;
using System;

namespace Caelum.Leilao.Test
{
    [TestClass]
    public class TestAvaliador
    {
        private Faker _faker;
        private Avaliador leiloeiro;
        private Usuario joao;
        private Usuario jose;
        private Usuario maria;
        private Usuario pedro;
        private Leilao leilao;
        private string nomeLeilao;

        [TestInitialize]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();

            joao = new Usuario("Joao");
            jose = new Usuario("Jose");
            maria = new Usuario("Maria");
            pedro = new Usuario("Pedro");
            leilao = new Leilao("Playstation 3 Novo");
            nomeLeilao = "Playstation 3 Novo";
        }

        [TestMethod]
        public void TestAvaliadorLancesEmOrdemCrescente()
        {
            //1ª Parte: cenário



            leilao = new CriadorDeLeilao().Para(nomeLeilao)
                .Lance(maria, 250)
                .Lance(joao, 300)
                .Lance(jose, 400)
                .Constroi();

            //2ª Parte: ação
            leiloeiro.Avalia(leilao);

            //3ª Parte: validação
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorDeTodos);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorDeTodos);
        }
        [TestMethod]
        public void TestAvaliadorLancesRandomicos()
        {
            _faker = new Faker();
            Leilao leilao2 = new Leilao(_faker.Random.String(null, 'a', 'z'));
            double MaiorValorEsperado = double.MinValue;
            double MenorValorEsperado = double.MaxValue;


            double valorGerado = PegaValor();
            leilao2.Propoe(new Lance(joao, valorGerado));
            TestaValores(ref MaiorValorEsperado, ref MenorValorEsperado, valorGerado);

            valorGerado = PegaValor();
            leilao2.Propoe(new Lance(jose, valorGerado));
            TestaValores(ref MaiorValorEsperado, ref MenorValorEsperado, valorGerado);

            valorGerado = PegaValor();
            leilao2.Propoe(new Lance(maria, valorGerado));
            TestaValores(ref MaiorValorEsperado, ref MenorValorEsperado, valorGerado);

            valorGerado = PegaValor();
            leilao2.Propoe(new Lance(pedro, valorGerado));
            TestaValores(ref MaiorValorEsperado, ref MenorValorEsperado, valorGerado);
            
            leiloeiro.Avalia(leilao2);
            Assert.AreEqual(MaiorValorEsperado, leiloeiro.MaiorDeTodos);
            Assert.AreEqual(MenorValorEsperado, leiloeiro.MenorDeTodos);
        }

        [TestMethod]
        public void TestAvaliadorUmLance()
        {
            //1ª Parte: cenário
            leilao = new CriadorDeLeilao().Para(nomeLeilao)
                .Lance(maria, 250)
                .Constroi();

            //2ª Parte: ação
            leiloeiro.Avalia(leilao);

            //3ª Parte: validação

            Assert.AreEqual(250.0, leiloeiro.MaiorDeTodos);
            Assert.AreEqual(250.0, leiloeiro.MenorDeTodos);
        }
        [TestMethod]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao()
                .Para(nomeLeilao)
                .Lance(joao, 100)
                .Lance(maria, 200)
                .Lance(joao, 300)
                .Lance(maria, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.0001);
            Assert.AreEqual(200, maiores[2].Valor, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NaoDeveLancarLeilaoNulo()
        {
            leiloeiro.Avalia(null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NaoDeveLancarLeilaoSemLances()
        {
            leiloeiro.Avalia(leilao);
        }


        private double PegaValor()
        {
            return _faker.Random.Double(50.0, 9000.0);
        }

        private static void TestaValores(ref double MaiorValorEsperado, ref double MenorValorEsperado, double valorGerado)
        {
            if (valorGerado > MaiorValorEsperado)
            {
                MaiorValorEsperado = valorGerado;
            }

            if (valorGerado < MenorValorEsperado)
            {
                MenorValorEsperado = valorGerado;
            }
        }

    }
}
