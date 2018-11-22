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
    public partial class EmpleadoForm : Form
    {
        private BindingSource ConexionDatos = new BindingSource();

        public EmpleadoForm()
        {
            InitializeComponent();
            ConexionDatos.DataSource = GestorDeArchivosDeEmpleado.Obtener();
            this.dataGridView1.DataSource = ConexionDatos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.CodigoDeEmpleado = txtCodigo.Text;
            nuevoEmpleado.CedulaDeCiudadania = txtCedula.Text;
            nuevoEmpleado.Nombres = txtNombre.Text;
            nuevoEmpleado.Apellidos = txtApellido.Text;
            nuevoEmpleado.Celular = txtCelular.Text;
            nuevoEmpleado.Correo = txtCorreo.Text;

            ConexionDatos.Add(nuevoEmpleado);

            GestorDeArchivosDeEmpleado.Guardar(nuevoEmpleado);

            txtCodigo.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }
    }
}
