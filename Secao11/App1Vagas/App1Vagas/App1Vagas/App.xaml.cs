using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1Vagas.Paginas;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1Vagas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ConsultaVagas() );
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
