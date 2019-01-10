using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace eNutrideal
{
    class AdicionarRefeicao
    {

        public static XmlElement NovaRefeicao(String nomeRefeicao, String item, String quantidade, String calorias, XmlDocument doc)
        {
            XmlElement refeicao = doc.CreateElement("Refeicao");
            refeicao.SetAttribute("nomeRefeicao", nomeRefeicao);
            refeicao.SetAttribute("item", item);
            refeicao.SetAttribute("quantidade", quantidade);
            refeicao.SetAttribute("calorias", calorias);

            return refeicao;
        }
     
    }
}
