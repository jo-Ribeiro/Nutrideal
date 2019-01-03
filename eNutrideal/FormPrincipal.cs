using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace eNutrideal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            cbAtividade.Items.Add("Taxa Metabólica Basal");
            cbAtividade.Items.Add("Sedentário - Pouco ou Nenhum Exercicio");
            cbAtividade.Items.Add("Ligeiramente Ativo - Atividade Fisica 1 a 3 vezes por Semana");
            cbAtividade.Items.Add("Moderadamente Ativo - Atividade Fisica 3 a 5 vezes por Semana");
            cbAtividade.Items.Add("Ativo - Atividade Fisica 6 a 7 vezes por Semana");
            cbAtividade.Items.Add("Extremamente Ativo - Atividade Fisica Muito Dificl ou Trabalho Fisico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade;
            double altura;
            double peso;

            if (!rbMasc1.Checked && !rbFem1.Checked)
            {
                MessageBox.Show("Seleciona o Género");
                return;
            }
            else if (String.IsNullOrEmpty(tbIdade1.Text) || String.IsNullOrWhiteSpace(tbIdade1.Text))
            {
                MessageBox.Show("Introduza a idade");
                return;
            }
            else if (String.IsNullOrEmpty(tbAltura1.Text) || String.IsNullOrWhiteSpace(tbAltura1.Text))
            {

                MessageBox.Show("Introduza a Altura");
                return;
            }
            else if (String.IsNullOrEmpty(tbPeso1.Text) || String.IsNullOrWhiteSpace(tbPeso1.Text))
            {

                MessageBox.Show("Introduza a Peso");
                return;
            }

            idade = int.Parse(tbIdade1.Text);
            altura = double.Parse(tbAltura1.Text);
            peso = double.Parse(tbPeso1.Text);

            if (rbMasc1.Checked)

            {
                double TMB = (10 * peso) + (6.25 * altura) - (5 * idade) + 5;
               // MessageBox.Show("Taxa Metabólica Basal" + TMB.ToString());
                Atividade(TMB);
            }
            else if (rbFem1.Checked)
            {
                double TMB = ((10 * peso) + (6.25 * altura) - (5 * idade)) - 161;
               // MessageBox.Show("Taxa Metabólica Basal" + TMB.ToString());
                Atividade(TMB);
            }
            else
            {
                MessageBox.Show("Escolha o Sexo");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo ler ficheiro
        }
    

        private void button3_Click(object sender, EventArgs e)
        {

            int idade;
            double altura;
            double pIdeal;
            double IMC;

            if (!rbMasc2.Checked && !rbFem2.Checked)
            {
                MessageBox.Show("Seleciona o Género");
                return;
            }
            else if (String.IsNullOrEmpty(tbIdade2.Text) || String.IsNullOrWhiteSpace(tbIdade2.Text))
            {
                MessageBox.Show("Introduza a idade");
                return;
            }
            else if (String.IsNullOrEmpty(tbAltura2.Text) || String.IsNullOrWhiteSpace(tbAltura2.Text))
            {

                MessageBox.Show("Introduza a Altura");
                return;
            }

            idade = int.Parse(tbIdade2.Text);
            altura = double.Parse(tbAltura2.Text);

            double diferencaAltura;
            double alturaMetros;
            double pesoMinimo;
            double pesoMaximo;

            if (altura < 152)
            {
                MessageBox.Show("A Altura tem que ser superior a 152 cm");

            }
            else if (rbMasc2.Checked)
            {


                diferencaAltura = (altura - 152) / 2.54;

                pIdeal = 52 + (1.9 * diferencaAltura);


                alturaMetros = altura * 0.01;

                IMC = pIdeal / (alturaMetros * alturaMetros);

                pesoMinimo = 18.5 * (alturaMetros * alturaMetros);
                pesoMaximo = 25 * (alturaMetros * alturaMetros);


                MessageBox.Show("O seu Peso Ideal: " + pIdeal.ToString() + '\n' + "O seu IMC= " + IMC + '\n' + "O seu peso recomendado é entre: " + pesoMinimo + " e " + pesoMaximo);

            }
            else if (rbFem2.Checked)
            {
                idade = int.Parse(tbIdade2.Text);

                diferencaAltura = (altura - 152) / 2.54;

                pIdeal = 49 + (1.7 * diferencaAltura);

                alturaMetros = altura * 0.01;

                IMC = pIdeal / (alturaMetros * alturaMetros);

                pesoMinimo = 18.5 * (alturaMetros * alturaMetros);
                pesoMaximo = 25 * (alturaMetros * alturaMetros);


                MessageBox.Show("O seu Peso Ideal: " + pIdeal.ToString() + '\n' + "O seu IMC= " + IMC + '\n' + "O seu peso recomendado é entre: " + pesoMinimo + " e " + pesoMaximo);


            }
        }

          
        public void Atividade(double TMB)
        {
          
            switch (cbAtividade.SelectedIndex)
            {
                    case 0:

                    MessageBox.Show(" Taxa Metabólica Basal:\n " + TMB + "Calorias");
                    break;

                    case 1:

                    double PA = TMB * 1.2;
                    MessageBox.Show("Estilo de Vida:\n Sedentário - Pouco ou Nenhum Exercicio:\n " + PA + "Calorias");
                    break;

                    case 2:

                    double LA = TMB * 1.375;
                    MessageBox.Show("Estilo de Vida:\n Ligeiramente Ativo - Atividade Fisica 1 a 3 vezes por Semana:\n " + LA + "Calorias");
                    break;

                    case 3:

                    double MA = TMB * 1.550;
                    MessageBox.Show("Estilo de Vida:\n Moderadamente Ativo - Atividade Fisica 3 a 5 vezes por Semana:\n " + MA + "Calorias");
                    break;

                    case 4:

                    double A = TMB * 1.725;
                    MessageBox.Show("Estilo de Vida:\n Ativo - Atividade Fisica 6 a 7 vezes por Semana:\n " + A + "Calorias");
                    break;

                    case 5:

                    double EA = TMB * 1.9;
                    MessageBox.Show("Estilo de Vida:\n Extremamente Ativo - Atividade Fisica Muito Dificl ou Trabalho Fisico:\n " + EA + "Calorias");
                    break;

                    default:
                    MessageBox.Show("Selecione o seu estilo de vida!!");
                    break;
                    


            }

        }

    }


}
