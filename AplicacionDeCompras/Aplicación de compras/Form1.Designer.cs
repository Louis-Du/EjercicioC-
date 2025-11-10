
namespace Aplicación_de_compras
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
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.lblValidarProductos = new System.Windows.Forms.Label();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.txtValorProductos = new System.Windows.Forms.TextBox();
            this.btnValorTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.Location = new System.Drawing.Point(56, 40);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(115, 13);
            this.lblCantidadProductos.TabIndex = 0;
            this.lblCantidadProductos.Text = "Cantidad de Productos";
            // 
            // lblValidarProductos
            // 
            this.lblValidarProductos.AutoSize = true;
            this.lblValidarProductos.Location = new System.Drawing.Point(59, 85);
            this.lblValidarProductos.Name = "lblValidarProductos";
            this.lblValidarProductos.Size = new System.Drawing.Size(90, 13);
            this.lblValidarProductos.TabIndex = 1;
            this.lblValidarProductos.Text = "Validar Productos";
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Location = new System.Drawing.Point(191, 40);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProductos.TabIndex = 2;
            this.txtCantidadProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProductos_KeyPress);
            // 
            // txtValorProductos
            // 
            this.txtValorProductos.Location = new System.Drawing.Point(191, 85);
            this.txtValorProductos.Name = "txtValorProductos";
            this.txtValorProductos.Size = new System.Drawing.Size(100, 20);
            this.txtValorProductos.TabIndex = 3;
            this.txtValorProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProductos_KeyPress);
            // 
            // btnValorTotal
            // 
            this.btnValorTotal.BackColor = System.Drawing.Color.Tan;
            this.btnValorTotal.Location = new System.Drawing.Point(102, 231);
            this.btnValorTotal.Name = "btnValorTotal";
            this.btnValorTotal.Size = new System.Drawing.Size(143, 41);
            this.btnValorTotal.TabIndex = 4;
            this.btnValorTotal.Text = "Mostrar Total de Compra";
            this.btnValorTotal.UseVisualStyleBackColor = false;
            this.btnValorTotal.Click += new System.EventHandler(this.btnValorTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.Location = new System.Drawing.Point(402, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Tan;
            this.btnLimpiar.Location = new System.Drawing.Point(286, 249);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidadProductos);
            this.groupBox1.Controls.Add(this.lblValidarProductos);
            this.groupBox1.Controls.Add(this.txtCantidadProductos);
            this.groupBox1.Controls.Add(this.txtValorProductos);
            this.groupBox1.Location = new System.Drawing.Point(74, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(502, 348);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValorTotal);
            this.Name = "Form1";
            this.Text = "Aplicación de Compras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.Label lblValidarProductos;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.TextBox txtValorProductos;
        private System.Windows.Forms.Button btnValorTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

