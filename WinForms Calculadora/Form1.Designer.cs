namespace WinForms_Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnCinco = new Button();
            btnOito = new Button();
            btnUm = new Button();
            btnQuatro = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnNove = new Button();
            btnDois = new Button();
            btnZero = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(14, 16);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(274, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(18, 141);
            btnSete.Margin = new Padding(3, 4, 3, 4);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(58, 51);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(83, 200);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(58, 51);
            btnCinco.TabIndex = 2;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(83, 141);
            btnOito.Margin = new Padding(3, 4, 3, 4);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(58, 51);
            btnOito.TabIndex = 3;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(18, 259);
            btnUm.Margin = new Padding(3, 4, 3, 4);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(58, 51);
            btnUm.TabIndex = 4;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(18, 200);
            btnQuatro.Margin = new Padding(3, 4, 3, 4);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(58, 51);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(149, 259);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(58, 51);
            btnTres.TabIndex = 6;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(149, 200);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(58, 51);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(149, 141);
            btnNove.Margin = new Padding(3, 4, 3, 4);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(58, 51);
            btnNove.TabIndex = 8;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(83, 259);
            btnDois.Margin = new Padding(3, 4, 3, 4);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(58, 51);
            btnDois.TabIndex = 9;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(83, 317);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(58, 51);
            btnZero.TabIndex = 10;
            btnZero.Text = "0\r\n";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(149, 317);
            btnIgual.Margin = new Padding(3, 4, 3, 4);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(58, 51);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(18, 317);
            btnVirgula.Margin = new Padding(3, 4, 3, 4);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(58, 51);
            btnVirgula.TabIndex = 12;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(217, 200);
            btnMultiplicacao.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(58, 51);
            btnMultiplicacao.TabIndex = 13;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(217, 141);
            btnDivisao.Margin = new Padding(3, 4, 3, 4);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(58, 51);
            btnDivisao.TabIndex = 14;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(217, 317);
            btnAdicao.Margin = new Padding(3, 4, 3, 4);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(58, 51);
            btnAdicao.TabIndex = 15;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(217, 259);
            btnSubtracao.Margin = new Padding(3, 4, 3, 4);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(58, 51);
            btnSubtracao.TabIndex = 16;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(217, 83);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(58, 51);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 380);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnVirgula);
            Controls.Add(btnIgual);
            Controls.Add(btnZero);
            Controls.Add(btnDois);
            Controls.Add(btnNove);
            Controls.Add(btnSeis);
            Controls.Add(btnTres);
            Controls.Add(btnQuatro);
            Controls.Add(btnUm);
            Controls.Add(btnOito);
            Controls.Add(btnCinco);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnCinco;
        private Button btnOito;
        private Button btnUm;
        private Button btnQuatro;
        private Button btnTres;
        private Button btnSeis;
        private Button btnNove;
        private Button btnDois;
        private Button btnZero;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnLimpar;
        private Label label1;
    }
}
