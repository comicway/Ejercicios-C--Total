using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nume1 = 10;
            var nume2 = 8;
            var suma = nume1 + nume2;

            var aprende = " aprende a sumar";

            double d1 = 5.5;
            double d2 = 1.1;
            double sumadou = nume1 + d2;
            Console.WriteLine("La suma de " + nume1 + " mas " + nume2 + " es " + suma + aprende);
            Console.Read();
        }
    }
}
