using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        public double MaiorDeTodos { get; set; } = double.MinValue;
        public double MenorDeTodos { get; set; } = double.MaxValue;
        private List<Lance> maiores; 

        public void Avalia(Leilao leilao)
        {
            if(leilao == null)
            {
                throw new ArgumentException("Leião não pode ser nulo");
            }
            if(leilao.Lances.Count == 0)
            {
                throw new ArgumentException("Não é possível avaliar leilões sem lances");
            }
            foreach (var lance in leilao.Lances)
            {
                if(lance.Valor > MaiorDeTodos)
                {
                    MaiorDeTodos = lance.Valor;
                }

                if (lance.Valor < MenorDeTodos)
                {
                    MenorDeTodos = lance.Valor;
                }
            }

            pegaOsMaioresNo(leilao);
        }

        private void pegaOsMaioresNo(Leilao leilao)
        {
            maiores = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor));
            if(maiores.Count > 3)
            {
                maiores = maiores.GetRange(0, 3);
            }
        }

        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
        }
    }
}
