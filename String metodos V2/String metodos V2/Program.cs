using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_metodos_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoUsuario;
            string letraSeleccion;

            Console.WriteLine("Escriba un texto aqui");
            textoUsuario = Console.ReadLine();
            Console.WriteLine("Ahora ingrese la letra que quiera seleccionar");
            letraSeleccion = Console.ReadLine();
            //letraSeleccion = Convert.ToString(letraSeleccion);
            Console.WriteLine("La posición de la letra es: " + textoUsuario.IndexOf(letraSeleccion));
           
            string nombre;
            string apellido;
            string nombreCompleto;

            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido");
            apellido = Console.ReadLine();
            nombreCompleto = nombre + " " + apellido;
            Console.WriteLine("Este es su nombre completo: {0}", nombreCompleto);
            Console.Read();
        }
    }
}
