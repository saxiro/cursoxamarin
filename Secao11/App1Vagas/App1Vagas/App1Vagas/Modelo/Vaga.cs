﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1Vagas.Modelo
{
    [Table("Vaga")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public short Quantidade { get; set; }
        public string Empresa { get; set; }
        public string Cidade { get; set; }
        public Double Salario { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
