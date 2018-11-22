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
    public partial class ClienteForm : Form
    {
        private List<Cliente> InventarioB = new List<Cliente>();

        private BindingSource ConexionDatosB = new BindingSource();

        public ClienteForm()
        {
            InitializeComponent();
            ConexionDatosB.DataSource = GestorDeArchivosCliente.Obtener();
            this.dataGridView1.DataSource = ConexionDatosB;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.CedulaDeCiudadania = txtCedula.Text;
            nuevoCliente.Nombres = txtNombre.Text;
            nuevoCliente.Apellidos = txtApellido.Text;
            nuevoCliente.Celular = txtCelular.Text;
            nuevoCliente.Correo = txtCorreo.Text;

            ConexionDatosB.Add(nuevoCliente);

            InventarioB.Add(nuevoCliente);

            GestorDeArchivosCliente.Guardar(nuevoCliente);

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
