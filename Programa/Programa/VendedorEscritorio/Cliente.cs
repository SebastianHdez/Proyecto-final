using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendedorEscritorio
{
    class Cliente : Persona
    {

        public override string ToString()
        {
            return $"{CedulaDeCiudadania};{Nombres};{Apellidos};{Celular};{Correo}";
        }
    }
}
