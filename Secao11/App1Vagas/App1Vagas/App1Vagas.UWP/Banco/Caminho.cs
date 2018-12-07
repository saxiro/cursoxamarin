using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using App1Vagas.Banco;
using App1Vagas.UWP.Banco;

[assembly: Dependency(typeof(Caminho))]
namespace App1Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCamiho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
