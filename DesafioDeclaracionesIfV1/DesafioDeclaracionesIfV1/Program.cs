using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeclaracionesIfV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su usuario de registro");
            string userName = Console.ReadLine();

            Console.WriteLine("Ahora ingrese su contraseña secreta");
            string userPass = Console.ReadLine();

            Console.WriteLine("Usted se ha registado con éxito");

            Console.WriteLine("¿Cual es su nombre de usuario?");
            string userName1 = Console.ReadLine();

            Console.WriteLine("¿Cual es su contraseña?");
            string userPass1 = Console.ReadLine();

            if (userName1 == userName && userPass == userPass1)
            {
                Console.WriteLine("Ustede se ha registrado con exito");
            }
            else {
                Console.WriteLine("El usuario o la contrasea son incorrectos");
            }

            Console.Read();
        }
    }
}
