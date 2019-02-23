using System;
using System.Collections.Generic;
using System.Text;

namespace Caelum.Leilao.Test
{
    public class CriadorDeLeilao
    {
        private Leilao leilao;

        public CriadorDeLeilao Para(string descricao)
        {

            this.leilao = new Leilao(descricao);

            return this;
        }

        public CriadorDeLeilao Lance(Usuario usuario, double valor)
        {

            leilao.Propoe(new Lance(usuario, valor));

            return this;
        }

        public Leilao Constroi()
        {
            return leilao;
        }
    }
}
