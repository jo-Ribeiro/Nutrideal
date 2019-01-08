using Newtonsoft.Json;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt ou JSON|*.txt;*.json";
            DialogResult result = o.ShowDialog();
            String pathFile = o.InitialDirectory + o.FileName; //digo que ficheiro abro e a diretoria
            String extensao = Path.GetExtension(pathFile).ToString();

            if (extensao == ".txt")
            {
                //chamar metodo para ler texto
                string ficheiro = File.ReadAllText(o.FileName);
                LerFicheiro.LerFicheiroTxt(ficheiro);

            }
            else if (extensao == ".json")
            {
                //chamar metodo para ler JSON
                using (StreamReader r = new StreamReader(pathFile))
                {
                    string jsonRefeicoes = r.ReadToEnd();
                    Console.WriteLine();
                    Console.ReadLine();

                    List<AdicionarRefeicao> Refeicoes = JsonConvert.DeserializeObject<List<AdicionarRefeicao>>(jsonRefeicoes);

                    foreach (AdicionarRefeicao refeicao in Refeicoes)
                    {
                        Console.WriteLine(refeicao);
                        MessageBox.Show("Ficheiro importado com sucesso");
                    }
                    Console.ReadLine();
                }
            }
            else
            {

                MessageBox.Show("Por favor escolha um ficheiro valido!");
            }



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
                    //perca de 0.25kg/semana - Mild weight loss (MWL)
                    double MWLPA = PA - 250;
                    //perca de 0.50kg/semana - Weight loss (WL)
                    double WLPA = PA - 500;
                    //perca de 1kg/semana - Extreme weight loss (EWL)
                    double EWLPA = PA - 1000;
                    //ganhar de 0.25kg/semana - Mild weight gain (MWG)
                    double MWGPA = PA + 250;
                    //ganhar de 0.50kg/semana - Weight gain (WG)
                    double WGPA = PA + 500;
                    //ganhar de 1kg/semana - Extreme weight gain (EWG)
                    double EWGPA = PA + 1000;
                    MessageBox.Show("Estilo de Vida:\n Sedentário - Pouco ou Nenhum Exercicio:\n " + PA + "Calorias\n"+
                        "\tPara uma perca de:\n 0,25 kg por semana: "+MWLPA + "Calorias\n 0,5 kg por semana: " + WLPA +
                        "Calorias\n 1,0 kg por semana: " + EWLPA + "Calorias \n \t Para um ganho de: \n 0,25 kg por semana" + MWGPA
                        + "Calorias\n 0,5 kg por semana: " + WGPA + "Calorias\n 1,0 kg por semana: " + EWGPA + "Calorias");
                    break;

                    case 2:

                    double LA = TMB * 1.375;
                    //perca de 0.25kg/semana - Mild weight loss (MWL)
                    double MWLLA = LA - 250;
                    //perca de 0.50kg/semana - Weight loss (WL)
                    double WLLA = LA - 500;
                    //perca de 1kg/semana - Extreme weight loss (EWL)
                    double EWLLA = LA - 1000;
                    //ganhar de 0.25kg/semana - Mild weight gain (MWG)
                    double MWGLA = LA + 250;
                    //ganhar de 0.50kg/semana - Weight gain (WG)
                    double WGLA = LA + 500;
                    //ganhar de 1kg/semana - Extreme weight gain (EWG)
                    double EWGLA = LA + 1000;

                    MessageBox.Show("Estilo de Vida:\n Ligeiramente Ativo - Atividade Fisica 1 a 3 vezes por Semana:\n " + LA + "Calorias\n" +
                        "\tPara uma perca de:\n 0,25 kg por semana: " + MWLLA + "Calorias\n 0,5 kg por semana: " + WLLA +
                        "Calorias\n 1,0 kg por semana: " + EWLLA + "Calorias \n \t Para um ganho de: \n 0,25 kg por semana" + MWGLA
                        + "Calorias\n 0,5 kg por semana: " + WGLA + "Calorias\n 1,0 kg por semana: " + EWGLA + "Calorias"); 
                    break;

                    case 3:

                    double MA = TMB * 1.550;
                    //perca de 0.25kg/semana - Mild weight loss (MWL)
                    double MWLMA = MA - 250;
                    //perca de 0.50kg/semana - Weight loss (WL)
                    double WLMA = MA - 500;
                    //perca de 1kg/semana - Extreme weight loss (EWL)
                    double EWLMA = MA - 1000;
                    //ganhar de 0.25kg/semana - Mild weight gain (MWG)
                    double MWGMA = MA + 250;
                    //ganhar de 0.50kg/semana - Weight gain (WG)
                    double WGMA = MA + 500;
                    //ganhar de 1kg/semana - Extreme weight gain (EWG)
                    double EWGMA = MA + 1000;
                    MessageBox.Show("Estilo de Vida:\n Moderadamente Ativo - Atividade Fisica 3 a 5 vezes por Semana:\n " + MA + "Calorias\n" +
                        "\tPara uma perca de:\n 0,25 kg por semana: " + MWLMA + "Calorias\n 0,5 kg por semana: " + WLMA +
                        "Calorias\n 1,0 kg por semana: " + EWLMA + "Calorias \n \t Para um ganho de: \n 0,25 kg por semana" + MWGMA
                        + "Calorias\n 0,5 kg por semana: " + WGMA + "Calorias\n 1,0 kg por semana: " + EWGMA + "Calorias");
                    break;

                    case 4:

                    double A = TMB * 1.725;
                    //perca de 0.25kg/semana - Mild weight loss (MWL)
                    double MWLA = A - 250;
                    //perca de 0.50kg/semana - Weight loss (WL)
                    double WLA = A - 500;
                    //perca de 1kg/semana - Extreme weight loss (EWL)
                    double EWLA = A - 1000;
                    //ganhar de 0.25kg/semana - Mild weight gain (MWG)
                    double MWGA = A + 250;
                    //ganhar de 0.50kg/semana - Weight gain (WG)
                    double WGA = A + 500;
                    //ganhar de 1kg/semana - Extreme weight gain (EWG)
                    double EWGA = A + 1000;
                    MessageBox.Show("Estilo de Vida:\n Ativo - Atividade Fisica 6 a 7 vezes por Semana:\n " + A + "Calorias\n" +
                        "\tPara uma perca de:\n 0,25 kg por semana: " + MWLA + "Calorias\n 0,5 kg por semana: " + WLA +
                        "Calorias\n 1,0 kg por semana: " + EWLA + "Calorias \n \t Para um ganho de: \n 0,25 kg por semana" + MWGA
                        + "Calorias\n 0,5 kg por semana: " + WGA + "Calorias\n 1,0 kg por semana: " + EWGA + "Calorias");
                    break;

                    case 5:

                    double EA = TMB * 1.9;
                    //perca de 0.25kg/semana - Mild weight loss (MWL)
                    double MWLEA = EA - 250;
                    //perca de 0.50kg/semana - Weight loss (WL)
                    double WLEA = EA - 500;
                    //perca de 1kg/semana - Extreme weight loss (EWL)
                    double EWLEA = EA - 1000;
                    //ganhar de 0.25kg/semana - Mild weight gain (MWG)
                    double MWGEA = EA + 250;
                    //ganhar de 0.50kg/semana - Weight gain (WG)
                    double WGEA = EA + 500;
                    //ganhar de 1kg/semana - Extreme weight gain (EWG)
                    double EWGEA = EA + 1000;
                    MessageBox.Show("Estilo de Vida:\n Extremamente Ativo - Atividade Fisica Muito Dificl ou Trabalho Fisico:\n " + EA + "Calorias\n" +
                        "\tPara uma perca de:\n 0,25 kg por semana: " + MWLEA + "Calorias\n 0,5 kg por semana: " + WLEA +
                        "Calorias\n 1,0 kg por semana: " + EWLEA + "Calorias \n \t Para um ganho de: \n 0,25 kg por semana" + MWGEA
                        + "Calorias\n 0,5 kg por semana: " + WGEA + "Calorias\n 1,0 kg por semana: " + EWGEA + "Calorias");
                    break;

                    default:
                    MessageBox.Show("Selecione o seu estilo de vida!!");
                    break;
                    


            }

        }

    }


}
