using System;
using System.Collections.Generic;
using System.Text;

namespace Pag24horasXamarin.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}