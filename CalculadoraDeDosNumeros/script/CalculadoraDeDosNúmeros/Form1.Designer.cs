namespace CalculadoraDeDosNúmeros
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
            this.lblprimernumero = new System.Windows.Forms.Label();
            this.lblsegundonumero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnrealizarsuma = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblprimernumero
            // 
            this.lblprimernumero.AutoSize = true;
            this.lblprimernumero.Font = new System.Drawing.Font("Ubuntu Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimernumero.Location = new System.Drawing.Point(6, 31);
            this.lblprimernumero.Name = "lblprimernumero";
            this.lblprimernumero.Size = new System.Drawing.Size(153, 23);
            this.lblprimernumero.TabIndex = 0;
            this.lblprimernumero.Text = "Primer Número";
            // 
            // lblsegundonumero
            // 
            this.lblsegundonumero.AutoSize = true;
            this.lblsegundonumero.Font = new System.Drawing.Font("Ubuntu Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundonumero.Location = new System.Drawing.Point(191, 31);
            this.lblsegundonumero.Name = "lblsegundonumero";
            this.lblsegundonumero.Size = new System.Drawing.Size(164, 23);
            this.lblsegundonumero.TabIndex = 1;
            this.lblsegundonumero.Text = "Segundo Número";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnrealizarsuma
            // 
            this.btnrealizarsuma.Location = new System.Drawing.Point(110, 194);
            this.btnrealizarsuma.Name = "btnrealizarsuma";
            this.btnrealizarsuma.Size = new System.Drawing.Size(119, 23);
            this.btnrealizarsuma.TabIndex = 4;
            this.btnrealizarsuma.Text = "SUMAR";
            this.btnrealizarsuma.UseVisualStyleBackColor = true;
            this.btnrealizarsuma.Click += new System.EventHandler(this.btnrealizarsuma_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(208, 303);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Location = new System.Drawing.Point(280, 194);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(119, 23);
            this.btnrestar.TabIndex = 6;
            this.btnrestar.Text = "RESTAR";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Location = new System.Drawing.Point(110, 248);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(119, 23);
            this.btnmultiplicacion.TabIndex = 7;
            this.btnmultiplicacion.Text = "MULTIPLICACIÖN";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "DIVISIÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(353, 33);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblsegundonumero);
            this.groupBox1.Controls.Add(this.lblprimernumero);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(60, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(530, 359);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnrealizarsuma);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Calculadora (Luis Dueñas)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblprimernumero;
        private System.Windows.Forms.Label lblsegundonumero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnrealizarsuma;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

