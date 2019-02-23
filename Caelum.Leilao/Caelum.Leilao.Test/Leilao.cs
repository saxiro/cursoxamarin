using System;
using System.Collections.Generic;
namespace Caelum.Leilao
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if(lance.Usuario == null)
            {
                throw new ArgumentException("A proposta não pode ser realizada por um usuário nulo");
            }
            if(lance.Valor <= 0)
            {
                throw new ArgumentException("O valor da proposta deve ser maior que zero");
            }
            if(Lances.Count == 0 || !Lances[Lances.Count - 1].Usuario.Equals(lance.Usuario))
            {
                Lances.Add(lance);
            }
        }

    }
}