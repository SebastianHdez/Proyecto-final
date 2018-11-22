using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendedorEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            ProductosFrom ventana = new ProductosFrom();
            ventana.ShowDialog();
        }

        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoForm ventana = new EmpleadoForm();
            ventana.ShowDialog();
        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            ClienteForm ventana = new ClienteForm();
            ventana.ShowDialog();
        }
    }
}
