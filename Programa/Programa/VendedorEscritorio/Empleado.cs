using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorEscritorio
{
     class Empleado : Persona
    {
        public string CodigoDeEmpleado { get; set; }

        public override string ToString()
        {
            return $"{CodigoDeEmpleado};{CedulaDeCiudadania};{Nombres};{Apellidos};{Celular};{Correo}";
        }
     }
}
