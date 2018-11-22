namespace VendedorEscritorio
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
            this.btnMenuProductos = new System.Windows.Forms.Button();
            this.btnMenuEmpleado = new System.Windows.Forms.Button();
            this.btnMenuCliente = new System.Windows.Forms.Button();
            this.btnMenuFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMenuProductos.Location = new System.Drawing.Point(12, 25);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Size = new System.Drawing.Size(75, 23);
            this.btnMenuProductos.TabIndex = 0;
            this.btnMenuProductos.Text = "Productos";
            this.btnMenuProductos.UseVisualStyleBackColor = false;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // btnMenuEmpleado
            // 
            this.btnMenuEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenuEmpleado.Location = new System.Drawing.Point(130, 67);
            this.btnMenuEmpleado.Name = "btnMenuEmpleado";
            this.btnMenuEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnMenuEmpleado.TabIndex = 1;
            this.btnMenuEmpleado.Text = "Empleado";
            this.btnMenuEmpleado.UseVisualStyleBackColor = false;
            this.btnMenuEmpleado.Click += new System.EventHandler(this.btnMenuEmpleado_Click);
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenuCliente.Location = new System.Drawing.Point(12, 107);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Size = new System.Drawing.Size(75, 23);
            this.btnMenuCliente.TabIndex = 2;
            this.btnMenuCliente.Text = "Cliente";
            this.btnMenuCliente.UseVisualStyleBackColor = false;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // btnMenuFactura
            // 
            this.btnMenuFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuFactura.Location = new System.Drawing.Point(130, 157);
            this.btnMenuFactura.Name = "btnMenuFactura";
            this.btnMenuFactura.Size = new System.Drawing.Size(75, 23);
            this.btnMenuFactura.TabIndex = 3;
            this.btnMenuFactura.Text = "Factura";
            this.btnMenuFactura.UseVisualStyleBackColor = false;
            this.btnMenuFactura.Click += new System.EventHandler(this.btnMenuFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(229, 212);
            this.Controls.Add(this.btnMenuFactura);
            this.Controls.Add(this.btnMenuCliente);
            this.Controls.Add(this.btnMenuEmpleado);
            this.Controls.Add(this.btnMenuProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuProductos;
        private System.Windows.Forms.Button btnMenuEmpleado;
        private System.Windows.Forms.Button btnMenuCliente;
        private System.Windows.Forms.Button btnMenuFactura;
    }
}

