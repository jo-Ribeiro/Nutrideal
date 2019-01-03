namespace eNutrideal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.calcCalorias = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbFem1 = new System.Windows.Forms.RadioButton();
            this.rbMasc1 = new System.Windows.Forms.RadioButton();
            this.tbPeso1 = new System.Windows.Forms.TextBox();
            this.tbAltura1 = new System.Windows.Forms.TextBox();
            this.tbIdade1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbFem2 = new System.Windows.Forms.RadioButton();
            this.rbMasc2 = new System.Windows.Forms.RadioButton();
            this.tbAltura2 = new System.Windows.Forms.TextBox();
            this.calcPeso = new System.Windows.Forms.Button();
            this.tbIdade2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbAtividade = new System.Windows.Forms.ComboBox();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ler ficheiro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calcCalorias
            // 
            this.calcCalorias.Location = new System.Drawing.Point(562, 106);
            this.calcCalorias.Name = "calcCalorias";
            this.calcCalorias.Size = new System.Drawing.Size(169, 58);
            this.calcCalorias.TabIndex = 1;
            this.calcCalorias.Text = "Calcular";
            this.calcCalorias.UseVisualStyleBackColor = true;
            this.calcCalorias.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Location = new System.Drawing.Point(12, 12);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(776, 310);
            this.tabMenu.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbAtividade);
            this.tabPage1.Controls.Add(this.rbFem1);
            this.tabPage1.Controls.Add(this.rbMasc1);
            this.tabPage1.Controls.Add(this.tbPeso1);
            this.tabPage1.Controls.Add(this.calcCalorias);
            this.tabPage1.Controls.Add(this.tbAltura1);
            this.tabPage1.Controls.Add(this.tbIdade1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculo de Calorias";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rbFem1
            // 
            this.rbFem1.AutoSize = true;
            this.rbFem1.Location = new System.Drawing.Point(206, 38);
            this.rbFem1.Name = "rbFem1";
            this.rbFem1.Size = new System.Drawing.Size(67, 17);
            this.rbFem1.TabIndex = 16;
            this.rbFem1.TabStop = true;
            this.rbFem1.Text = "Feminino";
            this.rbFem1.UseVisualStyleBackColor = true;
            // 
            // rbMasc1
            // 
            this.rbMasc1.AutoSize = true;
            this.rbMasc1.Location = new System.Drawing.Point(127, 38);
            this.rbMasc1.Name = "rbMasc1";
            this.rbMasc1.Size = new System.Drawing.Size(73, 17);
            this.rbMasc1.TabIndex = 15;
            this.rbMasc1.TabStop = true;
            this.rbMasc1.Text = "Masculino";
            this.rbMasc1.UseVisualStyleBackColor = true;
            // 
            // tbPeso1
            // 
            this.tbPeso1.Location = new System.Drawing.Point(128, 138);
            this.tbPeso1.Name = "tbPeso1";
            this.tbPeso1.Size = new System.Drawing.Size(99, 20);
            this.tbPeso1.TabIndex = 14;
            // 
            // tbAltura1
            // 
            this.tbAltura1.Location = new System.Drawing.Point(127, 103);
            this.tbAltura1.Name = "tbAltura1";
            this.tbAltura1.Size = new System.Drawing.Size(100, 20);
            this.tbAltura1.TabIndex = 13;
            // 
            // tbIdade1
            // 
            this.tbIdade1.Location = new System.Drawing.Point(127, 71);
            this.tbIdade1.Name = "tbIdade1";
            this.tbIdade1.Size = new System.Drawing.Size(100, 20);
            this.tbIdade1.TabIndex = 12;
            this.tbIdade1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genero";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbFem2);
            this.tabPage2.Controls.Add(this.rbMasc2);
            this.tabPage2.Controls.Add(this.tbAltura2);
            this.tabPage2.Controls.Add(this.calcPeso);
            this.tabPage2.Controls.Add(this.tbIdade2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculo de Peso Ideal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbFem2
            // 
            this.rbFem2.AutoSize = true;
            this.rbFem2.Location = new System.Drawing.Point(203, 18);
            this.rbFem2.Name = "rbFem2";
            this.rbFem2.Size = new System.Drawing.Size(67, 17);
            this.rbFem2.TabIndex = 8;
            this.rbFem2.TabStop = true;
            this.rbFem2.Text = "Feminino";
            this.rbFem2.UseVisualStyleBackColor = true;
            // 
            // rbMasc2
            // 
            this.rbMasc2.AutoSize = true;
            this.rbMasc2.Location = new System.Drawing.Point(124, 18);
            this.rbMasc2.Name = "rbMasc2";
            this.rbMasc2.Size = new System.Drawing.Size(73, 17);
            this.rbMasc2.TabIndex = 7;
            this.rbMasc2.TabStop = true;
            this.rbMasc2.Text = "Masculino";
            this.rbMasc2.UseVisualStyleBackColor = true;
            // 
            // tbAltura2
            // 
            this.tbAltura2.Location = new System.Drawing.Point(124, 93);
            this.tbAltura2.Name = "tbAltura2";
            this.tbAltura2.Size = new System.Drawing.Size(100, 20);
            this.tbAltura2.TabIndex = 6;
            // 
            // calcPeso
            // 
            this.calcPeso.Location = new System.Drawing.Point(509, 51);
            this.calcPeso.Name = "calcPeso";
            this.calcPeso.Size = new System.Drawing.Size(151, 58);
            this.calcPeso.TabIndex = 3;
            this.calcPeso.Text = "Calcular";
            this.calcPeso.UseVisualStyleBackColor = true;
            this.calcPeso.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbIdade2
            // 
            this.tbIdade2.Location = new System.Drawing.Point(124, 55);
            this.tbIdade2.Name = "tbIdade2";
            this.tbIdade2.Size = new System.Drawing.Size(100, 20);
            this.tbIdade2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gestor de Informação Calórica";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbAtividade
            // 
            this.cbAtividade.FormattingEnabled = true;
            this.cbAtividade.Location = new System.Drawing.Point(71, 183);
            this.cbAtividade.Name = "cbAtividade";
            this.cbAtividade.Size = new System.Drawing.Size(201, 21);
            this.cbAtividade.TabIndex = 17;
            this.cbAtividade.Text = "Nível de Atividade Fisica";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.button1);
            this.Name = "FormPrincipal";
            this.Text = "Pagina Principal";
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calcCalorias;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button calcPeso;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPeso1;
        private System.Windows.Forms.TextBox tbAltura1;
        private System.Windows.Forms.TextBox tbIdade1;
        private System.Windows.Forms.TextBox tbAltura2;
        private System.Windows.Forms.TextBox tbIdade2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFem1;
        private System.Windows.Forms.RadioButton rbMasc1;
        private System.Windows.Forms.RadioButton rbMasc2;
        private System.Windows.Forms.RadioButton rbFem2;
        private System.Windows.Forms.ComboBox cbAtividade;
    }
}

