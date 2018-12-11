using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pag24horasXamarin.Models
{
    public class DadosComunicacao
    {
        public string IPSiTef { get; set; }
        public string IdLoja { get; set; }
        public string IdTerminal { get; set; }
        public string Reservado { get; set; }
        public string ParametrosAdicionais { get; set; }
        public int EstadoComunicacao { get; set; }


        public DadosComunicacao()
        {
            DeleteJson();
            if (!File.Exists(LocalJson()))
            {
                IPSiTef = "192.168.254.86:4096";
                IdLoja = "00000000";
                IdTerminal = "SE000001";
                Reservado = "[TipoPinPad=ANDROID_BT;]";
                File.WriteAllText(LocalJson(), JsonConvert.SerializeObject(this));
            }
        }

        
        public static string LocalJson()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ServidorSitef.json");
        }
        public void CarregaJson()
        {
            string path = LocalJson();
            string ArquivoJson = File.ReadAllText(LocalJson());
            DadosComunicacao dc = JsonConvert.DeserializeObject<DadosComunicacao>(ArquivoJson);
            EstadoComunicacao = dc.EstadoComunicacao;
            IdLoja = dc.IdLoja;
            IdTerminal = dc.IdTerminal;
            IPSiTef = dc.IPSiTef;
            Reservado = dc.Reservado;
            ParametrosAdicionais = dc.ParametrosAdicionais;
            EstadoComunicacao = dc.EstadoComunicacao;
            //"/data/user/0/com.companyname.Pag24horasXamarin/files/.local/share/ServidorSitef.json"
        }
        public void SalvarJson()
        {
            File.WriteAllText(LocalJson(), JsonConvert.SerializeObject(this));
        }

        public void DeleteJson()
        {
            File.Delete(LocalJson());
        }
    }
}
