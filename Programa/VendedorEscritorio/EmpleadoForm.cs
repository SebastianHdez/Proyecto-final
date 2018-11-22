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
        private List<Empleado> InventarioC = new List<Empleado>();

        private BindingSource ConexionDatosC = new BindingSource();

        public EmpleadoForm()
        {
            InitializeComponent();
            ConexionDatosC.DataSource = GestorDeArchivosDeEmpleado.Obtener();
            this.dataGridView1.DataSource = ConexionDatosC;

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

            ConexionDatosC.Add(nuevoEmpleado);

            InventarioC.Add(nuevoEmpleado);

            GestorDeArchivosDeEmpleado.Guardar(nuevoEmpleado);


            txtCodigo.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
