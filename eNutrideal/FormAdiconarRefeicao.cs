using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace eNutrideal
{
    public partial class FormAdiconarRefeicao : Form
    {
        public FormAdiconarRefeicao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Close();
            formPrincipal.ShowDialog();


        }

        private void FormAdiconarRefeicao_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeRefeicao.Text == String.Empty || txtItem.Text == String.Empty || txtQuantidade_Dose.Text == String.Empty || txtCalorias.Text == String.Empty)
            {
                // validar campo adicionar
                MessageBox.Show("Dados introduzido incorretamente");
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.Load(@"Refeicao.xml");
                XmlNode root = doc.DocumentElement;

                String nomeRefeicao = txtNomeRefeicao.Text;
                String item = txtItem.Text;
                String quantidade = txtQuantidade_Dose.Text;
                String calorias = txtCalorias.Text;

                root.AppendChild(AdicionarRefeicao.NovaRefeicao(nomeRefeicao, item, quantidade, calorias, doc));
                MessageBox.Show("Refeicao adicionado com sucesso");

                doc.Save(@"Refeicao.xml");

                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.ShowDialog();


            }
        }

    }
}