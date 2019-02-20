using Bogus;
using CursoOnline.Dominio.Cursos;
using Moq;
using System;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        private readonly Mock<ICursoRepositorio> _cursoRepositorioMock;
        private readonly ArmazenadorDeCurso _armazenadorDeCurso;
        private readonly CursoDto _cursoDto;

        public ArmazenadorDeCursoTest()
        {
            var fake = new Faker();
            _cursoDto = new CursoDto
            {
                Nome = fake.Random.Words(),
                Descricao = fake.Lorem.Paragraph(),
                CargaHoraria = fake.Random.Double(20,120),
                PublicoAlvoId = fake.Random.Int(0,4),
                Valor = fake.Random.Double(100, 1000)
            };

            _cursoRepositorioMock = new Mock<ICursoRepositorio>();
            _armazenadorDeCurso = new ArmazenadorDeCurso(_cursoRepositorioMock.Object);
        }

        [Fact(DisplayName ="ArmazenadorDeCurso")]
        public void DeveAdicionarCurso()
        {
            _armazenadorDeCurso.Armazenar(_cursoDto);

            _cursoRepositorioMock.Verify(r => r.Adicionar(
                It.Is<Curso>(
                    c=> c.Nome         == _cursoDto.Nome          &&
                        c.Descricao    == _cursoDto.Descricao     &&
                        c.CargaHoraria == _cursoDto.CargaHoraria  &&
                        c.Valor        == _cursoDto.Valor
                    )
                
                ));
        }
    }

    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
    }

    public class ArmazenadorDeCurso
    {
        private ICursoRepositorio _cursoRepositorio;

        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        internal void Armazenar(CursoDto cursoDto)
        {
            var curso = 
                new Curso(cursoDto.Nome, 
                          cursoDto.Descricao, 
                          cursoDto.CargaHoraria, 
                          PublicoAlvo.Empreendedor, 
                          cursoDto.Valor
                          );
            _cursoRepositorio.Adicionar(curso);

        }
    }

    public class CursoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; set; }
        public int PublicoAlvoId { get; set; }
        public double Valor { get; set; }
    }
}
