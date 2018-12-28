﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Taxa Metabólica Basal" + TMB.ToString());
                Atividade(TMB);
            }
            else if (rbFem1.Checked)
            {
                double TMB = ((10 * peso) + (6.25 * altura) - (5 * idade)) - 161;
                MessageBox.Show("Taxa Metabólica Basal" + TMB.ToString());
                Atividade(TMB);
            }
            else
            {
                MessageBox.Show("Escolha o Sexo");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAtividade.Items.Add("Taxa Metabólica Basal");
            cbAtividade.Items.Add("Sedentário - Pouco ou Nenhum Exercicio");
            cbAtividade.Items.Add("Ligeiramente Ativo - Atividade Fisica 1 a 3 vezes por Semana");
            cbAtividade.Items.Add("Moderadamente Ativo - Atividade Fisica 3 a 5 vezes por Semana");
            cbAtividade.Items.Add("Ativo - Atividade Fisica 6 a 7 vezes por Semana");
            cbAtividade.Items.Add("Extremamente Ativo - Atividade Fisica Muito Dificl ou Trabalho Fisico");
        }

        public enum Atividades { TMB, PA, LA, MA, A, EA}
        public void Atividade(object TMB)
        {

            Atividades a = (Atividades)(new Random()).Next(0, 6);

            switch (a)
            {
                    case Atividades.TMB:

                    MessageBox.Show(" Taxa Metabólica Basal: " + TMB);
                    break;

                case Atividades.PA:
                    MessageBox.Show("Sedentário - Pouco ou Nenhum Exercicio");

            }

        }

    }


}
