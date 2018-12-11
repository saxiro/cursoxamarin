using Pag24horasXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Pag24horasXamarin.Banco;

namespace Pag24horasXamarin.Banco
{
    public class Database
    {
        private SQLiteConnection _conexao;
        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Login>();
        }
        public void Cadastrar(Login login)
        {
            _conexao.Insert(login);
        }
        public bool Consultar(Login login)
        {
            List<Login> lista = _conexao.Table<Login>().Where(a => a.Nome == login.Nome && a.Senha == login.Senha).ToList();
            int num = lista.Count;
            if (num > 0)
            {
                return true;
            }
            return false;
        }
    }
}
