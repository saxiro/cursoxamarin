﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1_Vagas.Modelos
{
    [Table("Vaga")]
    public class Vaga
    {
        [Primarykey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public short Quantidade { get; set; }
        public String Cidade { get; set; }
        public Double Salario { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
