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
        private BindingSource ConexionDatos = new BindingSource();

        public ClienteForm()
        {
            InitializeComponent();
            ConexionDatos.DataSource = GestorDeArchivosDeCliente.Obtener();
            this.dataGridView1.DataSource = ConexionDatos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.CedulaDeCiudadania = txtCedula.Text;
            nuevoCliente.Nombres = txtNombre.Text;
            nuevoCliente.Apellidos = txtApellido.Text;
            nuevoCliente.Celular = txtCelular.Text;
            nuevoCliente.Correo = txtCorreo.Text;

            ConexionDatos.Add(nuevoCliente);

            GestorDeArchivosDeCliente.Guardar(nuevoCliente);

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }
    }
}
