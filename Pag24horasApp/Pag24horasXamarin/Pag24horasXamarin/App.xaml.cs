using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pag24horasXamarin.Models;
using Pag24horasXamarin.Views;
using System.IO;
using Newtonsoft.Json;
using BR.Com.Softwareexpress.Sitef.Android;
using BR.Com.Softwareexpress.Sitef;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Pag24horasXamarin
{
    public partial class App : Application
    {
        private static Log l = new Log();
        public App()
        {
            InitializeComponent();
            //l.LimparLog();
            l.SetLog("Entrando na MainPage");
            MainPage = new MainPage();
            //MainPage = new LogPage();
        }

        protected override void OnStart()
        {
            l.SetLog("Testando Dados Gravados");
            if (!VerificaDados())
            {
                MainPage = new DadosComunicacaoPage();
            }
            else
            {
                int conectado = ChamaBiblioteca();
            }
            
        }

        private int ChamaBiblioteca()
        {
            l.SetLog("Chamando a Biblioteca");
            
            var dc = new DadosComunicacao();
            dc.CarregaJson();
            var cli = new CliSiTefI(Android.App.Application.Context);
            try
            {
                dc.EstadoComunicacao = 
                    cli.ConfiguraIntSiTefInterativoEx(dc.IPSiTef,
                                                      dc.IdLoja, 
                                                      dc.IdTerminal, 
                                                      dc.Reservado
                                                      );  
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro na conexão com SiTef - " + e.Message);
            }
           
            return dc.EstadoComunicacao;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        //Funções Complementares
        private bool VerificaDados()
        {
            var dc = new DadosComunicacao();
            if (dc.IPSiTef == null)
            {
                dc.CarregaJson();
            }
            return true;
        }

    }
}
