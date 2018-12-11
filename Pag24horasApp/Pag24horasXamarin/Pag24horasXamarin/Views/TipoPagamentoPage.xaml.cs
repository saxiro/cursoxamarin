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
    public partial class TipoPagamentoPage : ContentPage
    {
        public TipoPagamentoPage(string valor)
        {
            InitializeComponent();
            Valor.Text = "R$" + valor;
        }

        private void OnOptionSelected(Object sender, EventArgs args)
        {
            Button button = (Button)sender;
            string strOption = button.Text;         

            Navigation.PushAsync(new PagamentoPage(Valor.Text, strOption));
        }      
    }
}