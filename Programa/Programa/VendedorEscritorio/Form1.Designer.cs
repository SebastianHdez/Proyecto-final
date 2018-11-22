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
            this.SuspendLayout();
            // 
            // btnMenuProductos
            // 
            this.btnMenuProductos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMenuProductos.Location = new System.Drawing.Point(55, 12);
            this.btnMenuProductos.Name = "btnMenuProductos";
            this.btnMenuProductos.Size = new System.Drawing.Size(75, 23);
            this.btnMenuProductos.TabIndex = 0;
            this.btnMenuProductos.Text = "Productos";
            this.btnMenuProductos.UseVisualStyleBackColor = false;
            this.btnMenuProductos.Click += new System.EventHandler(this.btnMenuProductos_Click);
            // 
            // btnMenuEmpleado
            // 
            this.btnMenuEmpleado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenuEmpleado.Location = new System.Drawing.Point(55, 74);
            this.btnMenuEmpleado.Name = "btnMenuEmpleado";
            this.btnMenuEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnMenuEmpleado.TabIndex = 1;
            this.btnMenuEmpleado.Text = "Empleado";
            this.btnMenuEmpleado.UseVisualStyleBackColor = false;
            this.btnMenuEmpleado.Click += new System.EventHandler(this.btnMenuEmpleado_Click);
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenuCliente.Location = new System.Drawing.Point(55, 134);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Size = new System.Drawing.Size(75, 23);
            this.btnMenuCliente.TabIndex = 2;
            this.btnMenuCliente.Text = "Cliente";
            this.btnMenuCliente.UseVisualStyleBackColor = false;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(209, 178);
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
    }
}

