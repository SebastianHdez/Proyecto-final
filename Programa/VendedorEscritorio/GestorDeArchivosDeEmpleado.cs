using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VendedorEscritorio
{
    class GestorDeArchivosDeEmpleado
    {
        public const string RUTA = @"D:\Temporal\empleados.txt";

        public static bool Guardar(Empleado Empleado)
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
            writer.WriteLine(Empleado.ToString());
            writer.Flush();
            writer.Close();

            return true;
        }
        public static List<Empleado> Obtener()
        {
            List<Empleado> losEmpleados = new List<Empleado>();
            string linea;
            StreamReader file = new StreamReader(RUTA);
            while ((linea = file.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                Empleado nuevo = new Empleado
                {
                    CodigoDeEmpleado = datos[0],
                    CedulaDeCiudadania = datos[1],
                    Nombres = datos[2],
                    Apellidos = datos[3],
                    Celular = datos[4],
                    Correo = datos[5],
                };
                losEmpleados.Add(nuevo);
            }
            file.Close();
            return losEmpleados;
        }
    }
}
