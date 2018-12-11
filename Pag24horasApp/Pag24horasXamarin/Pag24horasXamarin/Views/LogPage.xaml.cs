using Pag24horasXamarin.Banco;
using Pag24horasXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pag24horasXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogPage : ContentPage
	{
        //Label LblSenha;


        public LogPage ()
		{
			InitializeComponent ();
            var l = new Log();
            Conteudo.Text = l.GetLog();
            
        
            
            //CarregaSenhas();
            Login login = new Login() { Nome = "saxiro", Senha = "123"};
            if (VerificaSenha(login))
            {
                LblSenha.Text = "Senha Ok";
            } else
            {
                LblSenha.Text = "Senha Incorreta";
            }
            
            
		}

        private bool VerificaSenha(Login login)
        {
            Database db = new Database();
            return db.Consultar(login);
        }

        public void CarregaSenhas()
        {
            Login l = new Login();
            l.Nome = "saxiro";
            l.Senha = "123";
            Database db = new Database();
            db.Cadastrar(l);
        }
	}
}