using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VendedorEscritorio
{
    class GestorDeArchivosDeProductos
    {
        public const string RUTA = @"D:\Temporal\productos.txt";

        public static bool Guardar(Producto producto)
        {
            FileInfo archivo = new FileInfo(RUTA);
            if (archivo.Exists == false)
            {
                FileStream nuevoFs = archivo.Create();
                StreamWriter nuevoWriter = new StreamWriter(nuevoFs);
                nuevoWriter.Write("");
                nuevoWriter.Flush();
                nuevoWriter.Close();
                nuevoFs.Close();
            }
            StreamWriter writer = archivo.AppendText();
            writer.WriteLine(producto.ToString());
            writer.Flush();
            writer.Close();

            return true;
        }
        public static List<Producto> Obtener()
        {
            List<Producto> losProductos = new List<Producto>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Producto nuevo = new Producto
                {
                    Codigo = datos[0],
                    NombreProducto = datos[1],
                    Cantidad = Convert.ToInt32(datos[2]),
                    Precio = Convert.ToDouble(datos[3]),
                    Imagen = datos[4]
                };
                losProductos.Add(nuevo);
            }
            return losProductos;
        }
    }
}
