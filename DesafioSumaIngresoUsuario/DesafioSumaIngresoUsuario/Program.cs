using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSumaIngresoUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcular();
            Console.Read();
        }
        public static void calcular()
        {
            Console.WriteLine("Por favor ingresa un número:");
            string num1 = Console.ReadLine();
            int num1Conver = int.Parse(num1);
            Console.WriteLine("Por favor ingresa otro número:");
            string num2 = Console.ReadLine();
            int num2Conver = int.Parse(num2);
            Console.WriteLine("Gracias por darnos los números ahora voy a sumar");
            Console.WriteLine("....................");
            Console.WriteLine("...................");
            Console.WriteLine("..................");
            Console.WriteLine("................");
            Console.WriteLine("...............");
            Console.WriteLine(".............");
            Console.WriteLine("............");
            Console.WriteLine("...........");
            Console.WriteLine(".........");
            Console.WriteLine("........");
            Console.WriteLine(".......");
            Console.WriteLine("......");
            Console.WriteLine(".....");
            Console.WriteLine("...");
            Console.WriteLine("..");
            Console.WriteLine(".");
            int suma = num1Conver + num2Conver;
            Console.WriteLine("La suma de " + num1Conver + " mas " + num2Conver + " es:");
            Console.WriteLine(suma);
            
        }
    
    }
}
