using Pag24horasXamarin.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pag24horasXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MenuPage()
        {
            InitializeComponent();

            var menuPage = new List<HomeMenuItem>();
            menuPage.Add(new HomeMenuItem
            {
                Title = "Caixa",
                IconSource = "",
                TargetType = typeof(CaixaPage)
            });
            menuPage.Add(new HomeMenuItem
            {
                Title = "Máquina",
                IconSource = "",
                TargetType = typeof(MaquinaPage)
            });
            menuPage.Add(new HomeMenuItem
            {
                Title = "Página padrão",
                IconSource = "",
                TargetType = typeof(ItemsPage)
            });
            menuPage.Add(new HomeMenuItem
            {
                Title = "Comunicação",
                IconSource = "",
                TargetType = typeof(DadosComunicacaoPage)
            });
            menuPage.Add(new HomeMenuItem
            {
                Title = "Sobre-nos",
                IconSource = "",
                TargetType = typeof(AboutPage)
            });
            listView.ItemsSource = menuPage;
        }
    }
}