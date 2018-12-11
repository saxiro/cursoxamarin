using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pag24horasXamarin.Models
{
    [Table("Login")]
    public class Login
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
