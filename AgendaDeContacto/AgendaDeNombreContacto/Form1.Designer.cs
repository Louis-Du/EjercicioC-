
namespace AgendaDeNombreContacto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.listNombresApellidos = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNumeroContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listNombresApellidosContacto = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listContacto = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.BackColor = System.Drawing.Color.OldLace;
            this.txtNombreApellido.Location = new System.Drawing.Point(236, 91);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(100, 20);
            this.txtNombreApellido.TabIndex = 1;
            this.txtNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellido_KeyPress);
            // 
            // listNombresApellidos
            // 
            this.listNombresApellidos.BackColor = System.Drawing.Color.OldLace;
            this.listNombresApellidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listNombresApellidos.FormattingEnabled = true;
            this.listNombresApellidos.Location = new System.Drawing.Point(29, 32);
            this.listNombresApellidos.Name = "listNombresApellidos";
            this.listNombresApellidos.Size = new System.Drawing.Size(120, 147);
            this.listNombresApellidos.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(386, 91);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 46);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // txtNumeroContacto
            // 
            this.txtNumeroContacto.BackColor = System.Drawing.Color.OldLace;
            this.txtNumeroContacto.Location = new System.Drawing.Point(236, 117);
            this.txtNumeroContacto.Name = "txtNumeroContacto";
            this.txtNumeroContacto.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroContacto.TabIndex = 5;
            this.txtNumeroContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroContacto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombres y Apellidos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.listNombresApellidosContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listContacto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listNombresApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(64, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // listNombresApellidosContacto
            // 
            this.listNombresApellidosContacto.BackColor = System.Drawing.Color.OldLace;
            this.listNombresApellidosContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listNombresApellidosContacto.FormattingEnabled = true;
            this.listNombresApellidosContacto.Location = new System.Drawing.Point(29, 256);
            this.listNombresApellidosContacto.Name = "listNombresApellidosContacto";
            this.listNombresApellidosContacto.Size = new System.Drawing.Size(263, 108);
            this.listNombresApellidosContacto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(38, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombres Apellidos y Contacto";
            // 
            // listContacto
            // 
            this.listContacto.BackColor = System.Drawing.Color.OldLace;
            this.listContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listContacto.FormattingEnabled = true;
            this.listContacto.Location = new System.Drawing.Point(172, 32);
            this.listContacto.Name = "listContacto";
            this.listContacto.Size = new System.Drawing.Size(120, 147);
            this.listContacto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contacto";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(411, 26);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(495, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 46);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(709, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumeroContacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agenda de Nombres y Apellidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.ListBox listNombresApellidos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNumeroContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listNombresApellidosContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

