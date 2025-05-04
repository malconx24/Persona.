using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Juan Javier", 35, "Calle F Villa Mella, Casa 88 C", "juan.javier@hotmail.com");

            ImprimirDatos impresora = new ImprimirDatos();
            impresora.Imprimir(persona);

            EnviarCorreoElectronico correo = new EnviarCorreoElectronico();
            correo.EnviarCorreo(persona.CorreoElectronico, "Bienvenida gracias por enviar la tarea del modulo1.");
        }
    }
}
