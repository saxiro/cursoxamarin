using BR.Com.Softwareexpress.Sitef.Android;
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
	public partial class PagamentoPage : ContentPage
	{
		public PagamentoPage (string valor, string strTipo)
		{
			InitializeComponent ();
            Valor.Text = valor;
            Tipo.Text = strTipo;
		}

        private void Pagar(Object sender, EventArgs args)
        {
            Console.WriteLine("Instanciando Objeto");
            var clisitef = CliSiTefI.Instance;                    

            //int retornoConfigura = clisitef.ConfiguraIntSiTefInterativoEx("192.168.254.86:4096", "00000000", "SE000001", "[TipoPinPad=ANDROID_BT;]");            

            int modalidade;

            string tipo = Tipo.Text;

            switch (tipo)
            {
                case "Pagamento Genérico":
                    modalidade = 0;
                    break;
                case "Cartão Débito":
                    modalidade = 2;
                    break;
                case "Cartão Crédito":
                    modalidade = 3;
                    break;
                case "Voucher":
                    modalidade = 5;
                    break;
                case "Crédito Centralizado":
                    modalidade = 6;
                    break;
                case "Cartao Combustível":
                    modalidade = 7;
                    break;
                default:
                    modalidade = 3;
                    break;
            }           

            string valor = Valor.Text;
            valor = valor.Replace("R$","");
            valor = valor.Replace(".", "");

            string cupomFiscal = "00000001";

            string dataFiscal = DateTime.Now.ToString("yyyyMMdd");

            string horario = DateTime.Now.ToString("HHmmss");

            string operador = "00000001";

            string restricoes = "";

            int retornoIC = clisitef.IniciaFuncaoSiTefInterativo(modalidade, valor, cupomFiscal, dataFiscal, horario, operador, restricoes);

            Console.Write("retornoIC = " + retornoIC);

            if (retornoIC == 10000)
            {
                //bool rodando = true;
                do
                {                    
                    retornoIC = clisitef.ContinuaFuncaoSiTefInterativo();
                    //Console.Write("retornoIC = " + retornoIC);
                    //if (retornoIC == 10000)
                    //{
                    //    proximoComando = clisitef.getProximoComando();
                    //    espera = true;
                    //    hndComando.sendEmptyMessage(proximoComando);
                    //    esperaFimColeta();
                    //}
                }
                while (/*rodando && */retornoIC == 10000);                
            }

            DisplayAlert("Retorno Transação", SitefDescricaoRetorno(retornoIC), "OK");
        }


        private String SitefDescricaoRetorno(int erro)
        {
            String result = "";
            if (erro != 0 && erro != 10000 && erro > 0)
            {
                result = "Negado pelo autorizador.";

            }
            else
            {
                switch (erro)
                {
                    case 0:
                        result = "Sucesso na execução da função.";
                        break;
                    case 10000:
                        result = "Deve ser chamada a rotina de continuidade do processo.";
                        break;
                    case -1:
                        result = "Módulo não inicializado. O PDV tentou chamar alguma rotina sem antes executara função configura.";
                        break;
                    case -2:
                        result = "Operação cancelada pelo operador.";
                        break;
                    case -3:
                        result = "O parâmetro função / modalidade é inválido.";
                        break;
                    case -4:
                        result = "Falta de memória no PDV.";
                        break;
                    case -5:
                        result = "Sem comunicação com o SiTef.";
                        break;
                    case -6:
                        result = "Operação cancelada pelo usuário (no pinpad).";
                        break;
                    case -7:
                        result = "Reservado";
                        break;
                    case -8:
                        result = "A CliSiTef não possui a implementação da função necessária, provavelmente está desatualizada (a CliSiTefI é mais recente).";
                        break;
                    case -9:
                        result = "A automação chamou a rotina ContinuaFuncaoSiTefInterativo sem antes iniciar uma função iterativa.";
                        break;
                    case -10:
                        result = "Algum parâmetro obrigatório não foi passado pela automação comercial.";
                        break;
                    case -12:
                        result = "Erro na execução da rotina iterativa. Provavelmente o processo iterativo anterior não foi finalizado até o final (enquanto o retorno for igual a 10000).";
                        break;
                    case -15:
                        result = "Operação cancelada pela automação comercial.";
                        break;
                    case -20:
                        result = "Parâmetro inválido passado para a função.";
                        break;
                    case -21:
                        result = "Utilizada uma palavra proibida, por exemplo SENHA, para coletar dados em aberto no pinpad. Por exemplo na função ObtemDadoPinpadDiretoEx.";
                        break;
                    case -25:
                        result = "Erro no Correspondente bancário: Deve realizar sangria.";
                        break;
                    case -30:
                        result = "Erro de acesso ao arquivo. Certifique-se que o usuário que roda a aplicação tem direitos de leitura/escrita.";
                        break;
                    case -40:
                        result = "Transação negada pelo SiTef.";
                        break;
                    case -41:
                        result = "Dados inválidos.";
                        break;
                    case -42:
                        result = "Retorno não previsto. Reservado";
                        break;
                    case -43:
                        result = "Problema na execução de alguma das rotinas no pinpad.";
                        break;
                    case -50:
                        result = "Transação não segura.";
                        break;
                    case -100:
                        result = "Erro interno do módulo.";
                        break;
                }                
            }
            return ("Código: " + erro.ToString() + "\n" + result);
        }
	}
} 