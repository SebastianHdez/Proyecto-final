﻿using System;
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
    public partial class ProductosFrom : Form
    {
        private List<Producto> InventarioA = new List<Producto>();

        private BindingSource ConexionDatosA = new BindingSource();


        public ProductosFrom()
        {
            InitializeComponent();
            ConexionDatosA.DataSource = GestorDeArchivosDeProductos.Obtener();
            this.dataGridView1.DataSource = ConexionDatosA;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.Codigo = txtCodigo.Text;
            nuevoProducto.NombreProducto = textBox2.Text;
            nuevoProducto.Cantidad = (int)nmrCantidad.Value;
            nuevoProducto.Precio = Convert.ToDouble(txtPrecio.Text);
            nuevoProducto.Imagen = pctImagenProducto.ImageLocation;

            ConexionDatosA.Add(nuevoProducto);
            InventarioA.Add(nuevoProducto);

            GestorDeArchivosDeProductos.Guardar(nuevoProducto);


            txtCodigo.Text = "";
            textBox2.Text = "";
            nmrCantidad.Value = 0;
            txtPrecio.Text = "";


        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes (*.jpg)|*.jpg";

            openFileDialog1.Multiselect = false;

            string imagen = "";

            while (string.IsNullOrEmpty(imagen))
            {
                var result = openFileDialog1.ShowDialog();
                imagen = openFileDialog1.FileName;
            }

            if (string.IsNullOrEmpty(imagen) == false)
            {
                pctImagenProducto.ImageLocation = imagen;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
