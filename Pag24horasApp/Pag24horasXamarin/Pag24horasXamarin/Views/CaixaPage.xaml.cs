using Pag24horasXamarin.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pag24horasXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CaixaPage : ContentPage
	{

        public CaixaPage ()
		{
            TestaComunicacao();
            InitializeComponent();
            //resultText.Text = "0,00";
        }

        private void TestaComunicacao()
        {
            Log l = new Log();
            DadosComunicacao dc = new DadosComunicacao();
            dc.CarregaJson();
            string msg = "";

            switch (dc.EstadoComunicacao)
            {
                case 0:
                    msg = "Comunicação feita com sucesso.";
                    Registra(l, msg);
                    break;
                case 1:
                    msg = "Endereço IP inválido ou não resolvido.";
                    Registra(l, msg);
                    break;
                case 2:
                    msg = "Código da loja inválido.";
                    Registra(l, msg);
                    break;
                case 3:
                    msg = "Código de terminal inválido.";
                    Registra(l, msg);
                    break;
                case 6:
                    msg = "Erro de inicialização do TCP/IP.";
                    Registra(l, msg);
                    break;
                case 7:
                    msg = "Falta de memória.";
                    Registra(l, msg);
                    break;
                case 8:
                    msg = "Não encontrou o CliSiTef ou está com problemas.";
                    Registra(l, msg);
                    break;
                case 9:
                    msg = "Configuração de servidores SiTef foi excedida.";
                    Registra(l, msg);
                    break;
                case 10:
                    msg = "Erro de acesso na pasta CliSiTef. (possível falta de permissão para escrita)";
                    Registra(l, msg);
                    break;
                case 11:
                    msg = "Dados inválidos passados pela automação.";
                    Registra(l, msg);
                    break;
                case 12:
                    msg = "Modo seguro não ativo. (possível falta de configuração no servidor SiTef do arquivo .cha)";
                    Registra(l, msg);
                    break;
                case 13:
                    msg = "Caminho DLL inválido. (o caminho completo das bibliotecas está muito grande)";
                    Registra(l, msg);
                    break;
                default:
                    break;

            }
        }

        private void Registra(Log l, string msg)
        {
            l.SetLog(msg);
            DisplayAlert("ERRO:", msg, "OK");
        }

        private void GoToTipoPagamento(object sender, EventArgs e)
        {
            string oldResultBuffer = resultText.Text;
            oldResultBuffer = oldResultBuffer.Replace(".", "");
            oldResultBuffer = oldResultBuffer.Replace(",", ".");

            double oldResultDouble = Double.Parse(oldResultBuffer);

            string oldTotalBuffer = totalText.Text;
            oldTotalBuffer = oldTotalBuffer.Replace("T: R$ ", "");
            oldTotalBuffer = oldTotalBuffer.Replace(".", "");
            oldTotalBuffer = oldTotalBuffer.Replace(",", ".");

            double oldTotalDouble = Double.Parse(oldTotalBuffer);

            if (oldTotalDouble > 0)
            {
                oldTotalBuffer = totalText.Text;
                oldTotalBuffer = oldTotalBuffer.Replace("T: R$ ", "");
                Navigation.PushAsync(new TipoPagamentoPage(oldTotalBuffer));
            }
            else if (oldResultDouble > 0)
            {
                Navigation.PushAsync(new TipoPagamentoPage(resultText.Text));
            }
            else {
                DisplayAlert("Digite um valor válido!", "", "OK");
            }
              
        }

        private void OnSoma(object sender, EventArgs e)
        {
            string oldResultBuffer = resultText.Text;
            oldResultBuffer = oldResultBuffer.Replace(".", "");
            oldResultBuffer = oldResultBuffer.Replace(",", ".");

            double oldResultDouble = Double.Parse(oldResultBuffer);

            string oldTotalBuffer = totalText.Text;
            oldTotalBuffer = oldTotalBuffer.Replace("T: R$ ", "");
            oldTotalBuffer = oldTotalBuffer.Replace(".", "");
            oldTotalBuffer = oldTotalBuffer.Replace(",", ".");

            double oldTotalDouble = Double.Parse(oldTotalBuffer);

            double newTotalDouble = oldResultDouble + oldTotalDouble;

            string newTotalBuffer = String.Format(new CultureInfo("pt-BR"), "{0:N}", newTotalDouble);

            if (newTotalBuffer.Length < 15)
            {
                totalText.Text = "T: R$ " + newTotalBuffer;

                string newResultBuffer = String.Format(new CultureInfo("pt-BR"), "{0:N}", 0);

                resultText.Text = newResultBuffer;
            }            
        }

        private void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;            

            string oldBuffer = resultText.Text;
            if (oldBuffer.Length < 14)
            {
                oldBuffer = oldBuffer.Replace(".", "");
                oldBuffer = oldBuffer.Replace(",", ".");

                double keyDouble = Double.Parse(pressed) / 100;

                double oldBufferDouble = Double.Parse(oldBuffer) * 10;

                double newBufferDouble = oldBufferDouble + keyDouble;

                string finalBuffer = String.Format(new CultureInfo("pt-BR"), "{0:N}", newBufferDouble);

                resultText.Text = finalBuffer;
            }
            else
            {
                resultText.Text = oldBuffer;
            }            
        }

        void OnClear(object sender, EventArgs e)
        {
            this.resultText.Text = "0,00";
            totalText.Text = "T: R$ 0,00";
        }

        void OnBackspace(object sender, EventArgs e)
        {            
            string oldBuffer = resultText.Text;
            oldBuffer = oldBuffer.Remove(oldBuffer.Length - 1);
            oldBuffer = oldBuffer.Replace(".", "");
            oldBuffer = oldBuffer.Replace(",", ".");

            double oldBufferDouble = Double.Parse(oldBuffer) / 10;

            double newBufferDouble = oldBufferDouble;

            string finalBuffer = String.Format(new CultureInfo("pt-BR"), "{0:N}", newBufferDouble);

            resultText.Text = finalBuffer;           
        }
    }
}