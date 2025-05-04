using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class EnviarCorreoElectronico
    {
        public void EnviarCorreo(string correo, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {correo} con mensaje: {mensaje}");
            Console.WriteLine("Correo enviado (simulado).");
        }
    }
}
