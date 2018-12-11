using Pag24horasXamarin.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pag24horasXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Menu.ListView.ItemSelected += OnItemSelected;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomeMenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                Menu.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}