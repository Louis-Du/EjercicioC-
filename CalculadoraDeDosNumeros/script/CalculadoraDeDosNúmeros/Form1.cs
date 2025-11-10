using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeDosNúmeros
{
    public partial class Form1 : Form
    {
        int primernumero, segundonumero, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            primernumero = int.Parse(textBox1.Text);
            segundonumero = int.Parse(textBox2.Text);
            resultado = primernumero - segundonumero;
            MessageBox.Show($"Resultado de la restar: {resultado.ToString()}");
            textBox1.Focus();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            primernumero = int.Parse(textBox1.Text);
            segundonumero = int.Parse(textBox2.Text);
            resultado = primernumero * segundonumero;
            MessageBox.Show($"Resultado de la multiplicación: {resultado.ToString()}");
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primernumero = int.Parse(textBox1.Text);
            segundonumero = int.Parse(textBox2.Text);

            if (primernumero != 0)
            {
                resultado = primernumero / segundonumero;
                MessageBox.Show($"Resultado de la división: {resultado.ToString()}");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show($"ERROR: No es posible dividir entre cero");
                textBox1.Focus();
            }
            
                if (segundonumero != 0)
            {
                resultado = primernumero / segundonumero;
                MessageBox.Show($"Resultado de la división: {resultado.ToString()}");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show($"ERROR: No es posible dividir entre cero");
                textBox1.Focus();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("!ERROR¡: No es posible hacer una operación aritmética con una letra.", "Proyecto Inicial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrealizarsuma_Click(object sender, EventArgs e)
        {
            primernumero = int.Parse(textBox1.Text);
            segundonumero = int.Parse(textBox2.Text);
            resultado = primernumero + segundonumero;
            MessageBox.Show($"Resultado de la suma: {resultado.ToString()}");
            textBox1.Focus();
        }
    }
}
