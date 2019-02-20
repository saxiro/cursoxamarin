using CursoOnline.Dominio.Cursos;
using System;

public class Curso
{
    public string Nome { get; private set; }
    public double CargaHoraria { get; private set; }
    public PublicoAlvo PublicoAlvo { get; private set; }
    public double Valor { get; private set; }
    public string Descricao { get; private set; }


    public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
    {
        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("Nome inválido");
        if (cargaHoraria < 1)
            throw new ArgumentException("Carga horária inválida");
        if (valor < 0)
            throw new ArgumentException("Valor inválido");

        Nome = nome;
        CargaHoraria = cargaHoraria;
        PublicoAlvo = publicoAlvo;
        Valor = valor;
        Descricao = descricao;
    }
}