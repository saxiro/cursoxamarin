using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pag24horasXamarin.Models
{
    public class Log
    {
        public String Conteudo { get; set; }

        public Log()
        {
            if(!File.Exists(LocalLog()))
            {
                File.Create(LocalLog());
            }
        }

        private string LocalLog()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "log.txt");
        }

        public void SetLog(String texto)
        {
            StreamWriter arquivo = File.AppendText(LocalLog());
            
                String cabecalho = DateTime.Now.ToString("dd/MM/yyyy - hh:MM:ss") + " - ";
                arquivo.WriteLine(cabecalho+texto);
            arquivo.Close();
                
            
        }
        public string GetLog()
        {
            String log = File.ReadAllText(LocalLog());
            return log;
        }
        public void LimparLog()
        {
            StreamWriter arquivo = File.CreateText(LocalLog());
            arquivo.WriteLine("");
            arquivo.Close();
        }
        
    }
}
