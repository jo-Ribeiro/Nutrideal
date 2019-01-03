﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace eNutrideal
{
    class LerFicheiro
    {
        public static void LerFicheiroTxt(string ficheiro)
        {

            String[] linha = ficheiro.Split('\n');

            List<String> linhas = new List<String>();

            XmlDocument doc = new XmlDocument(); // incializar o xml
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null); // para declaração do inico  do xml(obrigatorio)
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement(
                        "ListaRefeicao"); // Criar um root onde os Elementos ListaRefeicao irão ser introduzidos
            doc.AppendChild(root);

            String[] campo;

            for (int i = 0; i < linha.Length; i++)
            {
                linhas.Add(linha[i]); //Adiciona linhas a uma lista 
            }

            for (int a = 1; a < linhas.Count - 1; a++)
            {

                campo = linhas[a].Split('|'); //dividir pessoa por pipe

                for (int b = 0; b < campo.Length; b++) //remove os espaços e o caracter especial no 1
                {

                    campo[b] = campo[b].Replace(@"\s+", ""); // remove os espaços
                    campo[0] = campo[0].Replace(@"§", ""); //remove caracter especial que apenas aparece no primeiro elemento
                    campo[19] = campo[19].Replace('.', ',');


                    ////chamada do Metodo AddDonator a cada iteração que ira introduzir um Elemento Donator na DonatorsList
                    ///
                    //root.AppendChild(AdicionarRefeicao.NovoRefeicao(campo[0], campo[1], campo[2], campo[3], campo[4], campo[5], campo[6],
                    //  campo[7], campo[8], campo[9], campo[10], campo[11], campo[12], campo[13], campo[14], campo[15],
                    //   campo[16], campo[17], campo[18], campo[19], campo[20], campo[21], campo[22], campo[23], doc));

                    doc.Save(@"ListaRefeicao.xml");


                }
            }
        }
    }


}
    

