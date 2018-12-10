using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();
        }
        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }
        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Navigation.PushAsync(new DetalhesVagas());
        }
    }
}