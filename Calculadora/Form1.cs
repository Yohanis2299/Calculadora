using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1, number2, resultadosoma;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            resultadosoma = number1 / number2;

            resultado.Text = Convert.ToString(resultadosoma);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1, number2, resultadosoma; 

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);   

            resultadosoma = number1 + number2;

            resultado.Text = Convert.ToString(resultadosoma);


        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            int number1, number2, resultadosoma;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            resultadosoma = number1 - number2;

            resultado.Text = Convert.ToString(resultadosoma);

        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            int number1, number2, resultadosoma;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            resultadosoma = number1 * number2;

            resultado.Text = Convert.ToString(resultadosoma);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
