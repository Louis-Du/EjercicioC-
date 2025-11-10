
namespace CalculadoraDeSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblHorasLaboradas = new System.Windows.Forms.Label();
            this.lblValorSalario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValorSalario = new System.Windows.Forms.TextBox();
            this.txtHorasLaboradas = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(77, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(77, 128);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblHorasLaboradas
            // 
            this.lblHorasLaboradas.AutoSize = true;
            this.lblHorasLaboradas.Location = new System.Drawing.Point(219, 75);
            this.lblHorasLaboradas.Name = "lblHorasLaboradas";
            this.lblHorasLaboradas.Size = new System.Drawing.Size(88, 13);
            this.lblHorasLaboradas.TabIndex = 2;
            this.lblHorasLaboradas.Text = "Horas Laboradas";
            // 
            // lblValorSalario
            // 
            this.lblValorSalario.AutoSize = true;
            this.lblValorSalario.Location = new System.Drawing.Point(219, 128);
            this.lblValorSalario.Name = "lblValorSalario";
            this.lblValorSalario.Size = new System.Drawing.Size(83, 13);
            this.lblValorSalario.TabIndex = 3;
            this.lblValorSalario.Text = "Valor del Salario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtValorSalario
            // 
            this.txtValorSalario.Location = new System.Drawing.Point(222, 144);
            this.txtValorSalario.Name = "txtValorSalario";
            this.txtValorSalario.Size = new System.Drawing.Size(94, 20);
            this.txtValorSalario.TabIndex = 5;
            this.txtValorSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorSalario_KeyPress);
            // 
            // txtHorasLaboradas
            // 
            this.txtHorasLaboradas.Location = new System.Drawing.Point(222, 91);
            this.txtHorasLaboradas.Name = "txtHorasLaboradas";
            this.txtHorasLaboradas.Size = new System.Drawing.Size(94, 20);
            this.txtHorasLaboradas.TabIndex = 6;
            this.txtHorasLaboradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasLaboradas_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(80, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(94, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.BackColor = System.Drawing.Color.Bisque;
            this.btnCalcularSalario.Location = new System.Drawing.Point(133, 232);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(121, 38);
            this.btnCalcularSalario.TabIndex = 8;
            this.btnCalcularSalario.Text = "CALCULAR SALARIO";
            this.btnCalcularSalario.UseVisualStyleBackColor = false;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Introduce la siguiente información:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Bisque;
            this.btnSalir.Location = new System.Drawing.Point(317, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Bisque;
            this.btnLimpiar.Location = new System.Drawing.Point(317, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(423, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtHorasLaboradas);
            this.Controls.Add(this.txtValorSalario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblValorSalario);
            this.Controls.Add(this.lblHorasLaboradas);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "                                            Calculadora de Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblHorasLaboradas;
        private System.Windows.Forms.Label lblValorSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValorSalario;
        private System.Windows.Forms.TextBox txtHorasLaboradas;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

