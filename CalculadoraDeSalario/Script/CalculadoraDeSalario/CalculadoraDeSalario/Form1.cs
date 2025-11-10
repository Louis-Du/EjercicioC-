using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeSalario
{
    public partial class Form1 : Form
    {
        String nombre, apellido;
        double horasLaboradas, valorSalario, salarioFinal, horasExtras, valorSalarioExtras, horasExtrasAdicionales, valorSalarioExtrasAdicionales;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtHorasLaboradas.Text = "";
            txtValorSalario.Text = "";

        }

        private void txtValorSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese un digito valido.", "Calculara de Salirio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtHorasLaboradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese un digito valido.", "Calculara de Salirio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese un digito valido.", "Calculara de Salirio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese un digito valido.", "Calculara de Salirio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtHorasLaboradas.Text) || string.IsNullOrWhiteSpace(txtValorSalario.Text))
            {
                MessageBox.Show($"¡ERROR! No dejes espacios vacios.", "Calculadora de Salario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                horasLaboradas = double.Parse(txtHorasLaboradas.Text);
                valorSalario = double.Parse(txtValorSalario.Text);

                if (horasLaboradas <= 40)
                {
                    horasExtrasAdicionales = 0;
                    horasExtras = 0;

                    salarioFinal = valorSalario * horasLaboradas;
                    txtNombre.Focus();
                }

                else if (horasLaboradas >= 40 && horasLaboradas < 50)
                {
                    horasExtrasAdicionales = 0;
                    horasExtras = horasLaboradas - 40;
                    valorSalarioExtras = (horasExtras * valorSalario) * 2;

                    salarioFinal = (40 * valorSalario) + valorSalarioExtras;

                    txtNombre.Focus();
                }

                else if (horasLaboradas >= 50)
                {
                    horasExtrasAdicionales = horasLaboradas - 50;
                    valorSalarioExtrasAdicionales = (horasExtrasAdicionales * valorSalario) * 3;
                    horasExtras = (horasLaboradas - 40) - horasExtrasAdicionales;
                    valorSalarioExtras = (horasExtras * valorSalario) * 2;

                    salarioFinal = (40 * valorSalario) + valorSalarioExtras + valorSalarioExtrasAdicionales;
                }

                MessageBox.Show($"El trabajador {nombre} {apellido} trabajó un total de {horasLaboradas} horas con {horasExtras} horas extras y {horasExtrasAdicionales} horas extras adicionales \nSu salario es de {salarioFinal:N2}", "Calculadora de Salario");
                txtNombre.Focus();
            }
        }
    }
}
