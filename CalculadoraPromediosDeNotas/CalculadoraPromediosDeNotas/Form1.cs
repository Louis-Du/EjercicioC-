using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPromediosDeNotas
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSegundaNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir borrar (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese solo números.", "CALCULADORA PROMEDIOS DE NOTAS");
                return;
            }



            // Validar el rango
            if (double.TryParse(txtSegundaNota.Text + e.KeyChar, out double numero))
            {
                if (numero < 0 || numero > 5)
                {
                    e.Handled = true; // Bloquea la tecla
                    MessageBox.Show("¡ERROR! Solo se permiten números entre 1 y 5.", "CALCULADORA PROMEDIOS DE NOTAS");
                }
            }

        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimeraNota.Text) || string.IsNullOrWhiteSpace(txtSegundaNota.Text) || string.IsNullOrWhiteSpace(txtTerceraNota.Text) || string.IsNullOrWhiteSpace(txtCuartaNota.Text))
            {
                MessageBox.Show("¡ERROR! No dejes espacios vacios", "Calculadora de Promedio de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                double primeraNota = double.Parse(txtPrimeraNota.Text);
                double segundaNota = double.Parse(txtSegundaNota.Text);
                double tercerNota = double.Parse(txtTerceraNota.Text);
                double cuartaNota = double.Parse(txtCuartaNota.Text);
                double sumaTotalNotas, promedioFinal;

                sumaTotalNotas = (primeraNota * 0.3) + (segundaNota * 0.2) + (tercerNota * 0.4) + (cuartaNota * 0.1);
                promedioFinal = sumaTotalNotas / 1;

                if (promedioFinal <= 1.5)
                {
                    MessageBox.Show($"El promedio final {promedioFinal}. \nUsted no aprobó y no tiene derecho a recuperación");
                }
                else if (promedioFinal > 1.5 && promedioFinal < 3)
                {
                    MessageBox.Show($"El promedio final {promedioFinal}. \nusted no aprobó debe realizar recuperación");
                }
                else if (promedioFinal > 3 && promedioFinal < 3.8)
                {
                    MessageBox.Show($"El promedio final es de {promedioFinal} \nusted aprobó con la nota mínima");
                }
                else if (promedioFinal > 3.8 && promedioFinal < 4.5)
                {
                    MessageBox.Show($"El promedio final es de {promedioFinal} \nusted aprobó con un buen promedio");
                }
                else if (promedioFinal > 4.5)
                {
                    MessageBox.Show($"El promedio final es de {promedioFinal} \n Felicitaciones, usted aprobó con un excelente promedio");
                }
            }
        }

        private void txtPrimeraNota_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            // Permitir borrar (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese solo números.", "CALCULADORA PROMEDIOS DE NOTAS");
                return;
            }

            

            // Validar el rango
            if (double.TryParse(txtPrimeraNota.Text + e.KeyChar, out double numero))
            {
                if (numero < 0 || numero > 5)
                {
                    e.Handled = true; // Bloquea la tecla
                    MessageBox.Show("¡ERROR! Solo se permiten números entre 1 y 5.", "CALCULADORA PROMEDIOS DE NOTAS");
                }
            }
            
        }

        private void txtTerceraNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir borrar (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese solo números.", "CALCULADORA PROMEDIOS DE NOTAS");
                return;
            }



            // Validar el rango
            if (double.TryParse(txtTerceraNota.Text + e.KeyChar, out double numero))
            {
                if (numero < 0 || numero > 5)
                {
                    e.Handled = true; // Bloquea la tecla
                    MessageBox.Show("¡ERROR! Solo se permiten números entre 1 y 5.", "CALCULADORA PROMEDIOS DE NOTAS");
                }
            }
        }

        private void txtCuartaNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir borrar (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("¡ERROR! Ingrese solo números.", "CALCULADORA PROMEDIOS DE NOTAS");
                return;
            }



            // Validar el rango
            if (double.TryParse(txtCuartaNota.Text + e.KeyChar, out double numero))
            {
                if (numero < 0 || numero > 5)
                {
                    e.Handled = true; // Bloquea la tecla
                    MessageBox.Show("¡ERROR! Solo se permiten números entre 1 y 5.", "CALCULADORA PROMEDIOS DE NOTAS");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¡ADVERTENCIA! Uste está a punto de salir del programa ¿Estás seguro de que quiere continuar?", "CALCULADORA PROMEDIOS DE NOTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { 
                Application.Exit(); 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimeraNota.Text = ""; txtSegundaNota.Text = ""; txtTerceraNota.Text = ""; txtCuartaNota.Text = "";
        }
    }
}

