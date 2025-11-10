using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeNombreContacto
{
    public partial class Form1 : Form
    {
        // Se establecen los arreglos a utilizar.
        string[] nombresYApellidos = new string[10];
        int[] numeroContacto = new int[10];

        public Form1()
        {
            InitializeComponent();
            
            this.AcceptButton = btnRegistrar; // Permite ejecutar el botón registrar presionando la tecla enter. 
            this.CancelButton = btnSalir; // Permite ejecutar el botón salir presionando la tecla escape. 
        }

        int i = 0; // Se asigna el valor iniciar que tendra el indice al recorrer los arreglos.

        public void registraPersonas() // Procedimiento para registrar la información de las personas en los arreglos.
        {
            if (string.IsNullOrWhiteSpace(txtNombreApellido.Text) || string.IsNullOrWhiteSpace(txtNumeroContacto.Text))
            {
                MessageBox.Show($"¡ADVERTENCIA! No dejes espacios en blanco..", "Agenda de Nombres y Contactos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            else if ( i < nombresYApellidos.Length) // La condicional ejecuta si el indice es menor que el total de indice que está en el arreglo nombresYApellidos.
            {
                /*
                 * Esta condicional se encarga de agregar los nombres y apellidos y los contactos a sus respectivos arreglos. 
                 * Además borra la entrada permitiendo que el usuario ingrese una nueva información.
                 */
                nombresYApellidos[i] = txtNombreApellido.Text;
                numeroContacto[i] = int.Parse(txtNumeroContacto.Text);

                listNombresApellidos.Items.Add(nombresYApellidos[i]);
                listContacto.Items.Add(numeroContacto[i]);

                listNombresApellidosContacto.Items.Add(nombresYApellidos[i] + " - " + numeroContacto[i]);

                i++;

                txtNombreApellido.Clear();
                txtNumeroContacto.Clear();
                txtNombreApellido.Focus();
            }
            
            else // Si la condicional anterior no se ejecuta, es decir que los indices coincide muestra el siguiente mensaje.
            {
                MessageBox.Show($"¡ADVERTENCIA! Ya has ingresado todos los datos.", "Agenda de Nombres y Contactos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }
        public void limpiar() // Función que se encarga de limpiar las entradas.
        {
            txtNombreApellido.Clear();
            txtNumeroContacto.Clear();
            listNombresApellidos.Items.Clear();
            listContacto.Items.Clear();
            listNombresApellidosContacto.Items.Clear();
        }

        public void salirSistema() // Función que se encarga de confirmar la salida del usuario del sistema.
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Ejercicio de arreglos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*
         * Entradas y botones.
         */

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registraPersonas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salirSistema();
        }

        private void btnRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && !Char.IsControl(e.KeyChar)) 
            {
                /*
                 * Esta condicional mustra un mensaje de error cada vez que el usuario ingrese un dato diferente a un texto o control, además borra la entrada ingresada.
                 */
                e.Handled = true;
                MessageBox.Show($"¡ERROR! Solo se permite el ingreso de letras.", "Ejercicio 2 - Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                /*
                 * Esta condicional mustra un mensaje de error cada vez que el usuario ingrese un dato diferente a un digito o control, además borra la entrada ingresada.
                 */
                e.Handled = true;
                MessageBox.Show($"¡ERROR! Solo se permite el ingreso de números enteros.", "Ejercicio 2 - Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
