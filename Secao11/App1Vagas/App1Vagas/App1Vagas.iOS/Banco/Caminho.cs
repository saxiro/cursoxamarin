
using UIKit;
using System;
using System.IO;
using Foundation;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using App1Vagas.Banco;
using App1Vagas.iOS.Banco;
using System.Collections.Generic;

[assembly: Dependency(typeof(Caminho))]
namespace App1Vagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCamiho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");
            string caminhoBanco = Path.Combine(caminhoBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}