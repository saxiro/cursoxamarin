using System;
using System.Collections.Generic;
using System.Text;
using App1_Vagas.Modelos;
using Xamarin.Forms;
using SQLite;

namespace App1_Vagas.Banco
{
    public class Database
    {
        private SQLiteConnection _conexao;


        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            
            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Vaga>();
        }
        public void Cadastro(Vaga vaga)
        {
        }
        public List<Vaga> Consultar()
        {
            return null;
        }
        public Vaga ObterVagaPorId(int id)
        {
            return null;
        }
        public void Atualizacao(Vaga vaga)
        {

        }
        public void Exclusao(int id)
        {

        }
    }
}
