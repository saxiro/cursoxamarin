using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bogus;
using System;

namespace Caelum.Leilao.Test
{
    [TestClass]
    public class LeilaoTest
    {
        private Leilao leilao;

        [TestInitialize]
        public void CriaLeilao()
        {
            this.leilao = new Leilao("Macbook Pro 15");
        }
        
        [TestMethod]
        public void DeveReceberUmLance()
        {
            Assert.AreEqual(0, leilao.Lances.Count);

            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 200.0));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(200.0, leilao.Lances[0].Valor, 0.0001);
        }

        [TestMethod]
        public void DeveReceberVariosLances()
        {

            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 2000.0));
            leilao.Propoe(new Lance(new Usuario("Steve Wozniak"), 3000.0));

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);
            Assert.AreEqual(3000, leilao.Lances[1].Valor, 0.0001); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A proposta não pode ser realizada por um usuário nulo")]
        public void DeveReceberValoresValidos()
        {
            Usuario usuario = null;
            leilao.Propoe(new Lance(usuario, 2000.0));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-2)]
        [DataRow(-12)]
        [DataRow(-15)]
        [DataRow(-100)]
        [ExpectedException(typeof(ArgumentException), "O Valor deve ser maior que zero")]
        public void DeveReceberValorDaPropostaValido(int valor)
        {
            Usuario usuario = new Usuario("José Das Couves");
            leilao.Propoe(new Lance(usuario, valor));
        }

        [TestMethod]
        public void NaoDeveAceitarDoisLancesSeguidosDeMesmoUsuario()
        {
            var steveJobs = new Usuario("Steve Jobs");

            leilao.Propoe(new Lance(steveJobs, 2000));
            leilao.Propoe(new Lance(steveJobs, 3000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000, leilao.Lances[0].Valor, 0.0001);

        }

        [TestMethod]
        public void NaoDeveConterNenhumaPropostaDeLeilao()
        {
            Assert.AreEqual(0, leilao.Lances.Count);
        }
    }
}
