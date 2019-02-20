using Bogus;
using CursoOnline.Dominio.Cursos;
using CursoOnline.DominioTest._Builders;
using CursoOnline.DominioTest._Util;
using System;
using Xunit;
using Xunit.Abstractions;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTeste : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvo _publicoAlvo;
        private readonly double _valor;
        private readonly string _descricao;

        public CursoTeste(ITestOutputHelper output)
        {
            var faker = new Faker();
            _output = output;
            _output.WriteLine("Construtor sendo executado");
            _nome = faker.Company.CompanyName();
            _cargaHoraria = faker.Random.Double(50,1000);
            _publicoAlvo = PublicoAlvo.Estudante;
            _valor = faker.Finance.Random.Double(100, 1000);
            _descricao = faker.Lorem.Paragraph();

            _output.WriteLine($"Nome: {_nome}");
            _output.WriteLine($"Descrição: {_descricao}");
            _output.WriteLine($"Carga Horaria: {_cargaHoraria.ToString()}");
            _output.WriteLine($"Publico Alvo: {_publicoAlvo.ToString()}");
            _output.WriteLine($"Valor: {_valor.ToString()}");
        }

        public void Dispose()
        {
            _output.WriteLine("Dispose sendo executado");
        }

        [Fact(DisplayName = "CriarCurso")]
        public void DeveCriarCurso()
        {
            var curso = new Curso(_nome, _descricao, _cargaHoraria, _publicoAlvo, _valor);

            //CursoEsperado.ToExpectedObject().ShouldMatch(curso);

            Assert.Equal(_nome, curso.Nome);
            Assert.Equal(_cargaHoraria, curso.CargaHoraria);
            Assert.Equal(_publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(_valor, curso.Valor);
        }

        [Theory(DisplayName = "NomeInvalido")]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCursoTerUmNomeInvalido(string nomeInvalido)
        {
            Assert.Throws<ArgumentException>(() =>
            CursoBuilder.Novo().ComNome(nomeInvalido).Build())
            .ComMensagem("Nome inválido");
        }

        [Theory(DisplayName ="CargaHorariaMaiorQue1")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-50)]
        [InlineData(-100)]
        public void NaoDeveTerUmaCargaHorariaMenorQue1(double cargaHorariaInvalida)
        {
            Assert.Throws<ArgumentException>(() =>
            CursoBuilder.Novo().ComCargaHoraria(cargaHorariaInvalida).Build())
            .ComMensagem("Carga horária inválida");
        }

        [Theory(DisplayName = "ValorInvalido")]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-50)]
        [InlineData(-100)]
        public void NaoDeveTerUmValorMenorQue1(double valorInvalido)
        {
            Assert.Throws<ArgumentException>(() =>
            CursoBuilder.Novo().ComValor(valorInvalido).Build())
            .ComMensagem("Valor inválido");
        }
    }
}
