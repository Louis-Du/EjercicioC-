
namespace CalculadoraPromediosDeNotas
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
            this.lblPrimeraNota = new System.Windows.Forms.Label();
            this.lblTerceraNota = new System.Windows.Forms.Label();
            this.lblCuartaNota = new System.Windows.Forms.Label();
            this.lblSegundaNota = new System.Windows.Forms.Label();
            this.txtPrimeraNota = new System.Windows.Forms.TextBox();
            this.txtCuartaNota = new System.Windows.Forms.TextBox();
            this.txtTerceraNota = new System.Windows.Forms.TextBox();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeraNota
            // 
            this.lblPrimeraNota.AutoSize = true;
            this.lblPrimeraNota.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeraNota.Location = new System.Drawing.Point(51, 58);
            this.lblPrimeraNota.Name = "lblPrimeraNota";
            this.lblPrimeraNota.Size = new System.Drawing.Size(74, 13);
            this.lblPrimeraNota.TabIndex = 0;
            this.lblPrimeraNota.Text = "Primera Nota";
            // 
            // lblTerceraNota
            // 
            this.lblTerceraNota.AutoSize = true;
            this.lblTerceraNota.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceraNota.Location = new System.Drawing.Point(259, 58);
            this.lblTerceraNota.Name = "lblTerceraNota";
            this.lblTerceraNota.Size = new System.Drawing.Size(71, 13);
            this.lblTerceraNota.TabIndex = 1;
            this.lblTerceraNota.Text = "Tercera Nota";
            // 
            // lblCuartaNota
            // 
            this.lblCuartaNota.AutoSize = true;
            this.lblCuartaNota.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuartaNota.Location = new System.Drawing.Point(366, 58);
            this.lblCuartaNota.Name = "lblCuartaNota";
            this.lblCuartaNota.Size = new System.Drawing.Size(68, 13);
            this.lblCuartaNota.TabIndex = 2;
            this.lblCuartaNota.Text = "Cuarta Nota";
            // 
            // lblSegundaNota
            // 
            this.lblSegundaNota.AutoSize = true;
            this.lblSegundaNota.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundaNota.Location = new System.Drawing.Point(148, 58);
            this.lblSegundaNota.Name = "lblSegundaNota";
            this.lblSegundaNota.Size = new System.Drawing.Size(79, 13);
            this.lblSegundaNota.TabIndex = 3;
            this.lblSegundaNota.Text = "Segunda Nota";
            // 
            // txtPrimeraNota
            // 
            this.txtPrimeraNota.BackColor = System.Drawing.Color.Azure;
            this.txtPrimeraNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimeraNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimeraNota.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeraNota.Location = new System.Drawing.Point(54, 83);
            this.txtPrimeraNota.Name = "txtPrimeraNota";
            this.txtPrimeraNota.Size = new System.Drawing.Size(65, 13);
            this.txtPrimeraNota.TabIndex = 4;
            this.txtPrimeraNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrimeraNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimeraNota_KeyPress);
            // 
            // txtCuartaNota
            // 
            this.txtCuartaNota.BackColor = System.Drawing.Color.Azure;
            this.txtCuartaNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuartaNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuartaNota.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuartaNota.Location = new System.Drawing.Point(369, 83);
            this.txtCuartaNota.Name = "txtCuartaNota";
            this.txtCuartaNota.Size = new System.Drawing.Size(65, 13);
            this.txtCuartaNota.TabIndex = 5;
            this.txtCuartaNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuartaNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuartaNota_KeyPress);
            // 
            // txtTerceraNota
            // 
            this.txtTerceraNota.BackColor = System.Drawing.Color.Azure;
            this.txtTerceraNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerceraNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerceraNota.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerceraNota.Location = new System.Drawing.Point(262, 83);
            this.txtTerceraNota.Name = "txtTerceraNota";
            this.txtTerceraNota.Size = new System.Drawing.Size(65, 13);
            this.txtTerceraNota.TabIndex = 6;
            this.txtTerceraNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTerceraNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerceraNota_KeyPress);
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.BackColor = System.Drawing.Color.Azure;
            this.txtSegundaNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundaNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundaNota.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundaNota.Location = new System.Drawing.Point(151, 83);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(65, 13);
            this.txtSegundaNota.TabIndex = 7;
            this.txtSegundaNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSegundaNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundaNota_KeyPress);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCalcularPromedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcularPromedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularPromedio.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPromedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcularPromedio.Location = new System.Drawing.Point(182, 158);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(162, 36);
            this.btnCalcularPromedio.TabIndex = 8;
            this.btnCalcularPromedio.Text = "CALCULAR PROMEDIO";
            this.btnCalcularPromedio.UseVisualStyleBackColor = false;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(470, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(425, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(597, 227);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtTerceraNota);
            this.Controls.Add(this.txtCuartaNota);
            this.Controls.Add(this.txtPrimeraNota);
            this.Controls.Add(this.lblSegundaNota);
            this.Controls.Add(this.lblCuartaNota);
            this.Controls.Add(this.lblTerceraNota);
            this.Controls.Add(this.lblPrimeraNota);
            this.Name = "Form1";
            this.Text = "                                                              Calculadora de Prom" +
    "edio de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeraNota;
        private System.Windows.Forms.Label lblTerceraNota;
        private System.Windows.Forms.Label lblCuartaNota;
        private System.Windows.Forms.Label lblSegundaNota;
        private System.Windows.Forms.TextBox txtPrimeraNota;
        private System.Windows.Forms.TextBox txtCuartaNota;
        private System.Windows.Forms.TextBox txtTerceraNota;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

