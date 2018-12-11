using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Pag24horasXamarin.Models;
using BR.Com.Softwareexpress.Sitef.Android;

namespace Pag24horasXamarin.Droid
{
    [Activity(Label = "Pag24horasXamarin", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

           
        }

        private bool ChamaBiblioteca()
        {
            //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ServidorSitef.json");
            //string ArquivoJson = File.ReadAllText(path);
            //DadosComunicacao dc = JsonConvert.DeserializeObject<DadosComunicacao>(ArquivoJson);
            DadosComunicacao dc = new DadosComunicacao();
            dc.IPSiTef = "192.168.0.1";
            dc.IdLoja = "00000000";
            dc.IdTerminal = "SE000001";
            dc.Reservado = "[TipoPinPad=ANDROID_BT;]";

            var cli = new CliSiTefI(this.ApplicationContext);
            Console.Write("Resposta - " + CliSiTefI.Instance.ConfiguraIntSiTefInterativoEx(dc.IPSiTef, dc.IdLoja, dc.IdTerminal, dc.Reservado));
            return true;
        }
    }
}