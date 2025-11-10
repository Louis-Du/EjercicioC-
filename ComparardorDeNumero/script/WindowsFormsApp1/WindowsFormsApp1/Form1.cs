using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double primerNumero, segundoNumero, tercerNumero;

        private void btbNuevoNumero_Click(object sender, EventArgs e)
        {
            txtPrimerNumero.Text = "";
            txtSegundoNumero.Text = "";
            txtTercerNumero.Text = "";
            txtPrimerNumero.Focus();
        }

        private void btbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPrimerNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("!ERROR¡ Ingrese un digito valido.", "Evaluar Número Mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtSegundoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("!ERROR¡ Ingrese un digito valido.", "Evaluar Número Mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtTercerNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("!ERROR¡ Ingrese un digito valido.", "Evaluar Número Mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtPrimerNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Primero se evalua si hay un espacio
            if (string.IsNullOrWhiteSpace(txtPrimerNumero.Text) || string.IsNullOrWhiteSpace(txtSegundoNumero.Text) || string.IsNullOrWhiteSpace(txtTercerNumero.Text))
            {
                MessageBox.Show($"Ingresa los tres números.");
            }
            else
            {
                primerNumero = double.Parse(txtPrimerNumero.Text);
                segundoNumero = double.Parse(txtSegundoNumero.Text);
                tercerNumero = double.Parse(txtTercerNumero.Text);

                // se evalua si hay números son iguales
                if (primerNumero == segundoNumero && primerNumero == tercerNumero && segundoNumero == tercerNumero)
                {
                    MessageBox.Show($"Todos los números son iguales.");
                }
                else
                {
                    if (primerNumero > segundoNumero && primerNumero > tercerNumero)
                    {
                        MessageBox.Show($"{primerNumero} es mayor.");
                    }
                    else if (segundoNumero > primerNumero && segundoNumero > tercerNumero)
                    {
                        MessageBox.Show($"{segundoNumero} es mayor.");
                    }
                    else if (tercerNumero > primerNumero && tercerNumero > segundoNumero)
                    {
                        MessageBox.Show($"{tercerNumero} es mayor.");
                    }

                    // En caso de que hay dos números iguales y mayores que otro se ejecuta estas condiciones.

                    if (primerNumero == segundoNumero && primerNumero > tercerNumero)
                    {
                        MessageBox.Show($"{primerNumero} es mayor.");
                    }

                    else if (primerNumero == tercerNumero && primerNumero > segundoNumero)
                    {
                        MessageBox.Show($"{primerNumero} es mayor.");
                    }

                    else if (tercerNumero == segundoNumero && tercerNumero > primerNumero)
                    {
                        MessageBox.Show($"{tercerNumero} es mayor.");
                    }

                    // En caso de que hay dos números iguales y menores que otro se ejecuta este codigo.
                    if (primerNumero == segundoNumero && primerNumero < tercerNumero)
                    {
                        MessageBox.Show($"{primerNumero} es menor.");
                    }

                    else if (primerNumero == tercerNumero && primerNumero < segundoNumero)
                    {
                        MessageBox.Show($"{primerNumero} es menor.");
                    }

                    else if (tercerNumero == segundoNumero && tercerNumero < primerNumero)
                    {
                        MessageBox.Show($"{tercerNumero} es menor.");
                    }

                    if (primerNumero < segundoNumero && primerNumero < tercerNumero)
                    {
                        MessageBox.Show($"{primerNumero} es menor.");
                    }
                    else if (segundoNumero < primerNumero && segundoNumero < tercerNumero)
                    {
                        MessageBox.Show($"{segundoNumero} es menor.");
                    }

                    else if (tercerNumero < primerNumero && tercerNumero < segundoNumero)
                    {
                        MessageBox.Show($"{tercerNumero} es menor.");
                    }
                }
            }

            txtPrimerNumero.Focus();
        }
    }
}
