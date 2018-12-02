using App01_ControleXF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "João Rodrigues", Idade = "18"});
            lista.Add(new Pessoa { Nome = "Maria Rodrigues", Idade = "21"});
            lista.Add(new Pessoa { Nome = "Felipe Rodrigues", Idade = "24"});
            lista.Add(new Pessoa { Nome = "José Rodrigues", Idade = "30"});
            lista.Add(new Pessoa { Nome = "Mariana Rodrigues", Idade = "31"});
            ListaPessoas.ItemsSource = lista;
        }
	}
}