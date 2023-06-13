using System.Globalization;

namespace Calculadora {
    public partial class Form1 : Form {
        /*vamos criar duas variaveis que vão servir 
        para guardamos o valor que o usuário digitou na calculadora */
        decimal valor1 = 0, valor2 = 0;
        //e mais uma variavel que vai ter valor vazio
        string operacao = "";
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TxtResultado.Text += "7";
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load_1(object sender, EventArgs e) {

        }

        private void TxtResultado_TextChanged_1(object sender, EventArgs e) {

        }

        private void button16_Click(object sender, EventArgs e) {
            TxtResultado.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e) {
            TxtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e) {
            TxtResultado.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e) {
            TxtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e) {
            TxtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e) {
            TxtResultado.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e) {
            TxtResultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e) {
            TxtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e) {
            TxtResultado.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e) {
            TxtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e) {

            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "SOMA";
            labelOperacao.Text = "+";

        }

        private void button15_Click(object sender, EventArgs e) {
            valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA") {
                TxtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUB") {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULT") {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
            } else {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button9_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "SUB";
            labelOperacao.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "MULT";
            labelOperacao.Text = "*";
        }

        private void button18_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "DIV";
            labelOperacao.Text = "*";
        }

        private void button5_Click(object sender, EventArgs e) {

            TxtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) {
            //limpando o valor das variaveis e a operação
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }
    }
}