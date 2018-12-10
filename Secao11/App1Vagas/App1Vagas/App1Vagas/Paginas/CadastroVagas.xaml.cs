using App1Vagas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1Vagas.Banco;

namespace App1Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVagas : ContentPage
    {
        public CadastroVagas()
        {
            InitializeComponent();
        }
        public void SalvarAction(object sender, EventArgs args)
        {
            //TODO - Validar Dados do Cadastro
            Vaga vaga = new Vaga();
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
            database.Cadastro(vaga);
            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
            Navigation.PopAsync();
        }
    }
}