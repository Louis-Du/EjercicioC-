
namespace WindowsFormsApp1
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
            this.lblPrimerNumero = new System.Windows.Forms.Label();
            this.lblTercerNumero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtPrimerNumero = new System.Windows.Forms.TextBox();
            this.txtTercerNumero = new System.Windows.Forms.TextBox();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.btbDeterminarMayorMenor = new System.Windows.Forms.Button();
            this.btbSalir = new System.Windows.Forms.Button();
            this.btbNuevoNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimerNumero
            // 
            this.lblPrimerNumero.AutoSize = true;
            this.lblPrimerNumero.Location = new System.Drawing.Point(65, 58);
            this.lblPrimerNumero.Name = "lblPrimerNumero";
            this.lblPrimerNumero.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerNumero.TabIndex = 0;
            this.lblPrimerNumero.Text = "Primer Número";
            // 
            // lblTercerNumero
            // 
            this.lblTercerNumero.AutoSize = true;
            this.lblTercerNumero.Location = new System.Drawing.Point(299, 58);
            this.lblTercerNumero.Name = "lblTercerNumero";
            this.lblTercerNumero.Size = new System.Drawing.Size(78, 13);
            this.lblTercerNumero.TabIndex = 1;
            this.lblTercerNumero.Text = "Tercer Número";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(170, 58);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Segundo Número";
            // 
            // txtPrimerNumero
            // 
            this.txtPrimerNumero.Location = new System.Drawing.Point(68, 85);
            this.txtPrimerNumero.Name = "txtPrimerNumero";
            this.txtPrimerNumero.Size = new System.Drawing.Size(59, 20);
            this.txtPrimerNumero.TabIndex = 3;
            this.txtPrimerNumero.TextChanged += new System.EventHandler(this.txtPrimerNumero_TextChanged);
            this.txtPrimerNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNumero_KeyPress);
            // 
            // txtTercerNumero
            // 
            this.txtTercerNumero.Location = new System.Drawing.Point(302, 85);
            this.txtTercerNumero.Name = "txtTercerNumero";
            this.txtTercerNumero.Size = new System.Drawing.Size(59, 20);
            this.txtTercerNumero.TabIndex = 4;
            this.txtTercerNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTercerNumero_KeyPress);
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(186, 85);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(59, 20);
            this.txtSegundoNumero.TabIndex = 5;
            this.txtSegundoNumero.TextChanged += new System.EventHandler(this.txtSegundoNumero_TextChanged);
            this.txtSegundoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNumero_KeyPress);
            // 
            // btbDeterminarMayorMenor
            // 
            this.btbDeterminarMayorMenor.BackColor = System.Drawing.SystemColors.Info;
            this.btbDeterminarMayorMenor.Location = new System.Drawing.Point(173, 178);
            this.btbDeterminarMayorMenor.Name = "btbDeterminarMayorMenor";
            this.btbDeterminarMayorMenor.Size = new System.Drawing.Size(121, 39);
            this.btbDeterminarMayorMenor.TabIndex = 6;
            this.btbDeterminarMayorMenor.Text = "Determinar Número Mayor/Menor";
            this.btbDeterminarMayorMenor.UseVisualStyleBackColor = false;
            this.btbDeterminarMayorMenor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbSalir
            // 
            this.btbSalir.BackColor = System.Drawing.SystemColors.Info;
            this.btbSalir.Location = new System.Drawing.Point(428, 29);
            this.btbSalir.Name = "btbSalir";
            this.btbSalir.Size = new System.Drawing.Size(75, 23);
            this.btbSalir.TabIndex = 7;
            this.btbSalir.Text = "SALIR";
            this.btbSalir.UseVisualStyleBackColor = false;
            this.btbSalir.Click += new System.EventHandler(this.btbSalir_Click);
            // 
            // btbNuevoNumero
            // 
            this.btbNuevoNumero.BackColor = System.Drawing.SystemColors.Info;
            this.btbNuevoNumero.Location = new System.Drawing.Point(359, 182);
            this.btbNuevoNumero.Name = "btbNuevoNumero";
            this.btbNuevoNumero.Size = new System.Drawing.Size(93, 31);
            this.btbNuevoNumero.TabIndex = 8;
            this.btbNuevoNumero.Text = "Nuevo Número";
            this.btbNuevoNumero.UseVisualStyleBackColor = false;
            this.btbNuevoNumero.Click += new System.EventHandler(this.btbNuevoNumero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(550, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btbNuevoNumero);
            this.Controls.Add(this.btbSalir);
            this.Controls.Add(this.btbDeterminarMayorMenor);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.txtTercerNumero);
            this.Controls.Add(this.txtPrimerNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblTercerNumero);
            this.Controls.Add(this.lblPrimerNumero);
            this.Name = "Form1";
            this.Text = "                                                            Evaluar Número Mayor " +
    "y Menor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimerNumero;
        private System.Windows.Forms.Label lblTercerNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txtPrimerNumero;
        private System.Windows.Forms.TextBox txtTercerNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Button btbDeterminarMayorMenor;
        private System.Windows.Forms.Button btbSalir;
        private System.Windows.Forms.Button btbNuevoNumero;
    }
}

