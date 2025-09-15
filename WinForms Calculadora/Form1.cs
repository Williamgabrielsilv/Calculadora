namespace WinForms_Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal valor { get; set; }

        private Operacao operacaoselecionada { get; set; }
        public object TextResultado { get; private set; }

        private enum Operacao
        {
            Adicao,
            subtracao,
            multiplicacao,
            divisao,

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = Operacao.Adicao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";



        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = Operacao.subtracao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = Operacao.multiplicacao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = Operacao.divisao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            object convert = null;
            switch (operacaoselecionada)
            {
                case Operacao.Adicao:
                    Resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtracao:
                    Resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.multiplicacao:
                    Resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.divisao:
                    Resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    break;





            }
            txtResultado.Text = convert.ToString();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {


            if (!txtResultado.Text.Contains(","))
                TextResultado.text += ",";
        }
    }
}
