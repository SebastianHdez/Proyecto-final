using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorEscritorio
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string NombreProducto { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        public string Imagen { get; set; }

        public override string ToString()
        {
            return $"{Codigo};{NombreProducto};{Cantidad};{Precio};{Imagen}";
        }
    }
}
