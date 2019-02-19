using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTeste
    {
        [Fact(DisplayName = "CriarCurso")]
        public void DeveCriarCurso()
        {
            var CursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            var curso = new Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.Valor);

            //CursoEsperado.ToExpectedObject().ShouldMatch(curso);

            Assert.Equal(CursoEsperado.Nome, curso.Nome);
            Assert.Equal(CursoEsperado.CargaHoraria, curso.CargaHoraria);
            Assert.Equal(CursoEsperado.PublicoAlvo, curso.PublicoAlvo);
            Assert.Equal(CursoEsperado.Valor, curso.Valor);
        }

        [Theory(DisplayName = "NomeInvalido")]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCursoTerUmNomeInvalido(string nomeInvalido)
        {
            var CursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            var message = Assert.Throws<ArgumentException>(() =>
            new Curso(nomeInvalido, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.Valor))
            .Message;
            Assert.Equal("Nome inválido", message);

        }

        [Theory(DisplayName ="CargaHorariaMaiorQue1")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-50)]
        [InlineData(-100)]
        public void NaoDeveTerUmaCargaHorariaMenorQue1(double cargaHorariaInvalida)
        {
            var CursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };

            var message = Assert.Throws<ArgumentException>(() =>
            new Curso(CursoEsperado.Nome, cargaHorariaInvalida, CursoEsperado.PublicoAlvo, CursoEsperado.Valor))
            .Message;

            Assert.Equal("Carga horária inválida", message);
        }

        [Theory(DisplayName = "ValorInvalido")]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-50)]
        [InlineData(-100)]
        public void NaoDeveTerUmValorMenorQue1(double valorInvalido)
        {
            var CursoEsperado = new
            {
                Nome = "Informática básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (double)950
            };
            var message = Assert.Throws<ArgumentException>(() =>
            new Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, valorInvalido))
            .Message;

            Assert.Equal("Valor inválido", message);
        }
    }

    public enum PublicoAlvo
    {
        Estudante,
        Universitario,
        Empregado,
        Empreendedor
    }

    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor { get; private set; }

        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            if (string.IsNullOrEmpty(nome) )
                throw new ArgumentException("Nome inválido");
            if(cargaHoraria < 1)
                throw new ArgumentException("Carga horária inválida");
            if(valor < 0)
                throw new ArgumentException("Valor inválido");

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }
    }
}
