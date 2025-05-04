using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class ImprimirDatos
    {
        public void Imprimir(Persona persona)
        {
            Console.WriteLine("Información de la Persona:");
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo: {persona.CorreoElectronico}");
        }
    }
}