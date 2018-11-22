using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VendedorEscritorio
{
    class GestorDeArchivosCliente
    {
        public const string RUTA = @"D:\Temporal\clientes.txt";

        public static bool Guardar(Cliente cliente)
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
            writer.WriteLine(cliente.ToString());
            writer.Flush();
            writer.Close();

            return true;
        }
        public static List<Cliente> Obtener()
        {
            List<Cliente> losClientes = new List<Cliente>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Cliente nuevo = new Cliente
                {
                    CedulaDeCiudadania = datos[0],
                    Nombres = datos[1],
                    Apellidos = datos[2],
                    Celular = datos[3],
                    Correo = datos[4],
                };
                losClientes.Add(nuevo);
            }
            file.Close();
            return losClientes;
        }
    }
}
