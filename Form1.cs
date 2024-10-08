namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        double num1, num2, result;
        int count;
        bool resultadoExibido = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Clear();
                textBox1.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Botão de soma
            num1 = double.Parse(textBox1.Text); // Convertendo o conteúdo da textBox1 para double e armazenando em num1
            textBox1.Clear(); // Limpando a textBox1 para permitir que o usuário digite o segundo número
            count = 4; // Indica que a operação é soma
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Botao de igual

            // armazenando o segundo numero da textbox em num2
            num2 = double.Parse(textBox1.Text);
            switch (count)
            {
                case 1:
                    result = num1 + num2;
                    textBox1.Text = Convert.ToString(result);
                    resultadoExibido = true;

                    break;

                case 2:
                    result = num1 - num2;
                    textBox1.Text = Convert.ToString(result);
                    resultadoExibido = true;
                    break;

                case 3:
                    result = num1 * num2;
                    textBox1.Text = Convert.ToString(result);
                    resultadoExibido = true;
                    break;
                case 4:
                    result = num1 / num2;
                    textBox1.Text = Convert.ToString(result);
                    resultadoExibido = true;
                    break;

                default:
                    break;

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "1";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "5";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (resultadoExibido == true)
            {
                textBox1.Clear();
                resultadoExibido = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Botao de soma
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear(); // Limpando a textBox1 para permitir que o usuário digite o segundo número
            count = 1;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Clear();
                textBox1.Text = "0";
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            //Botao de substrair
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
