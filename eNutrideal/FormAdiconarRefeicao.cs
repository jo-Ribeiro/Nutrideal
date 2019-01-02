using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
