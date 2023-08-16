/*
1.	Crie uma calculadora simples com botões numéricos e operadores.
2.	Implemente a lógica para realizar cálculos básicos (adição, subtração, etc.) quando os botões forem clicados.
3.	Use TableLayoutPanel ou FlowLayoutPanel para organizar os controles.
*/

using System.Globalization;

namespace LayouteControles_Básicos
{
    public partial class txtresultado : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public txtresultado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            textBoxResultado.Text = "";

            operacao = "SOMA";

            label1.Text = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            label1.Text = "=";

            if (operacao == "SOMA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);

            }
            else if (operacao == "SUBTRACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }

            valor1 = valor2;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
            operacao = "";
            textBoxResultado.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            textBoxResultado.Text = "";

            operacao = "SUBTRACAO";

            label1.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            textBoxResultado.Text = "";

            operacao = "MULTIPLICACAO";

            label1.Text = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            textBoxResultado.Text = "";

            operacao = "DIVISAO";

            label1.Text = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }
    }
}