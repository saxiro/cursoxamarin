using System;
using System.Linq;
using System.Text;
using App1Vagas.Banco;
using App1Vagas.Modelo;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarVaga : ContentPage
	{
        private Vaga vaga { get; set; }
		public EditarVaga (Vaga vaga)
		{
			InitializeComponent ();
            this.vaga = vaga;
            Vaga.Text = vaga.NomeVaga;
            Empresa.Text = vaga.Empresa;
            Quantidade.Text = vaga.Quantidade.ToString();
            Cidade.Text = vaga.Cidade;
            Salario.Text = vaga.Salario.ToString();
            Descricao.Text = vaga.Descricao;
            TipoContratacao.IsToggled = (vaga.Tipo == "CLT")?false:true;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;
		}
        public void SalvarAction(object sender, EventArgs args)
        {
            vaga.NomeVaga = Vaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.Tipo = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;
            Database database = new Database();
            database.Atualizacao(vaga);
            //TODO - Redirecionar para a tela de Minhas Vagas Cadastradas
            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
        }

    }
}