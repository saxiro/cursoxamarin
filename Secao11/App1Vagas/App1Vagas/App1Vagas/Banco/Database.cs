using App1Vagas.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using App1Vagas.Banco;
using Xamarin.Forms;

namespace App1Vagas.Banco
{
    public class Database
    {
        private SQLiteConnection _conexao;

        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCamiho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Vaga>();
        }
        
        public void Cadastro(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }
        public Vaga Pesquisa(string nome)
        {
            return _conexao.Table<Vaga>().Where(a => a.NomeVaga.Contains(nome)).FirstOrDefault();
        }
        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }
        public Vaga ObterVagaPorId(int Id)
        {
            return _conexao.Table<Vaga>().Where(a => a.Id == Id).FirstOrDefault();
        }
        public void Atualizacao(Vaga vaga)
        {
            _conexao.Update(vaga);
        }
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }
    }
}
