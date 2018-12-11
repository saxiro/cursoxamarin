using Newtonsoft.Json;
using Pag24horasXamarin.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pag24horasXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DadosComunicacaoPage : ContentPage
    {
		public DadosComunicacaoPage ()
        {
            InitializeComponent();
            PegaDados();
            Enviar.Clicked += PaginaPrincipal;
        }

        private void PegaDados()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ServidorSitef.json");
            string ArquivoJson = File.ReadAllText(path);
            DadosComunicacao dc = JsonConvert.DeserializeObject<DadosComunicacao>(ArquivoJson);
            IPSiTef.Text = dc.IPSiTef;
            IdLoja.Text = dc.IdLoja;
            IdTerminal.Text = dc.IdTerminal;
            Reservado.Text = dc.Reservado;
        }

        private void PaginaPrincipal(object sender, EventArgs args)
        {
            string iPSiTef = IPSiTef.Text;
            string idLoja = IdLoja.Text;
            string idTerminal = IdTerminal.Text;
            string reservado = Reservado.Text;

            if (iPSiTef != "" && idLoja != "" && idTerminal != "")
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ServidorSitef.json");
                string ArquivoJson = File.ReadAllText(path);
                DadosComunicacao dc = JsonConvert.DeserializeObject<DadosComunicacao>(ArquivoJson);
                dc.IPSiTef = iPSiTef;
                dc.IdLoja = idLoja;
                dc.IdTerminal = idTerminal;
                dc.Reservado = reservado;
                string ArquivoAlterado = JsonConvert.SerializeObject(dc);
                File.WriteAllText(path, ArquivoAlterado);
                
            }
        }
	}
}