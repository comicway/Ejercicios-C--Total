using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_string_y_sus_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Por favor ingrese su nombre y el de su pololo, luego precione Enter");
            
            nombre = Console.ReadLine();
            
            Console.WriteLine("En mayusculas: " + nombre.ToUpper());
            Console.WriteLine("En minusculas: " + nombre.ToLower());
            Console.WriteLine("Sin espacios principo y final: " + nombre.Trim());
            Console.WriteLine("Sin espacios: " + nombre.Replace(" ",""));
            Console.WriteLine("El Substring 3: " + nombre.Substring(3));
            Console.Read();
        }
    }
}
