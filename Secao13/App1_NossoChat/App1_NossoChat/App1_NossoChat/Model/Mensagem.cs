using System;
using System.Collections.Generic;
using System.Text;

namespace App1_NossoChat.Model
{
    public class Mensagem
    {
        public int Id { get; set; }
        public int ChatID { get; set; }
        public int UsuarioID { get; set; }
        public string mensagem { get; set; }
        public Usuario usuario { get; set; }
    }
}
