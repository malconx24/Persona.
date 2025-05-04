using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
    }
}