using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNutrideal
{
    class AdicionarRefeicao
    {
        public string NomeRefeicao { get; set; }
        public string Item { get; set; }
        public string Quantidade { get; set; }
        public string Calorias { get; set; }

        public AdicionarRefeicao(string nomeRefeicao, string item, string quantidade, string calorias)
        {
            this.NomeRefeicao = nomeRefeicao;
            this.Item = item;
            this.Quantidade = quantidade;
            this.Calorias = calorias;
        }

        public override string ToString()
        {
            return NomeRefeicao + "\t" + Item + "\t" + Quantidade + "\t" + Calorias;
        }
    }
}
