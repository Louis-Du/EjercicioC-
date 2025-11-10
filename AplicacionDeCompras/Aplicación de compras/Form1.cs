using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_de_compras
{
    public partial class Form1 : Form
    {
        int CantidadProductos;
        double valorProducto, valorNetoCompra, valorTotalCompra, valorMasIVA, descuento;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {   
            if (MessageBox.Show("¿Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes);
            Application.Exit();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidadProductos.Text = "";
            txtValorProductos.Text = "";
            txtCantidadProductos.Focus();
        }

        private void btnValorTotal_Click(object sender, EventArgs e)
        {
            CantidadProductos = int.Parse(txtCantidadProductos.Text);
            valorProducto = double.Parse(txtValorProductos.Text);
            valorNetoCompra = (valorProducto * CantidadProductos);
            valorMasIVA = valorNetoCompra * 0.19;
            valorTotalCompra = valorMasIVA + valorNetoCompra;

            if (txtCantidadProductos.Text == "" || txtValorProductos.Text == "")
            {
                MessageBox.Show("ERROR: No has ingresado un valor.", "Aplicación de compra", MessageBoxButtons.OK,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (valorTotalCompra > 200000)
            {
                descuento = valorTotalCompra * 0.1;
                MessageBox.Show($"Tienes un descuento de {descuento}");
                MessageBox.Show($"La compra tiene un valor de {valorTotalCompra - descuento}%");
            }
            else
            {
                MessageBox.Show($"La compra tiene un valor de {valorTotalCompra}");

            }
        }
        /*
         * Validar solo números.
         */

        private void txtCantidadProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                        MessageBox.Show("!ERROR¡ Ingrese un digito valido.", "Aplicación de compra", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
        }

        private void txtValorProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("!ERROR¡ Ingrese un digito valido.", "Aplicación de compra", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
