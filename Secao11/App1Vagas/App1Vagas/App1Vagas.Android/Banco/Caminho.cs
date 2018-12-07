using System;
using System.IO;
using Android.OS;
using System.Linq;
using System.Text;
using Android.App;
using Android.Views;
using Xamarin.Forms;
using Android.Widget;
using Android.Content;
using App1Vagas.Banco;
using Android.Runtime;
using App1Vagas.Droid.Banco;
using System.Collections.Generic;

[assembly:Dependency(typeof(Caminho))]
namespace App1Vagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCamiho(string nomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBanco = Path.Combine(caminhoDaPasta, nomeArquivoBanco);
            return caminhoBanco;
        }
    }
}