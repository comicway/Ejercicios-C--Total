using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParingStringAInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miString = "15";
            string mi2String = "10";

            //solamente contatenas los string
            string resul = miString + mi2String;

            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(mi2String);
            int resul2 = num1 + num2;

            Console.WriteLine("Resultado del contatenado de string: " + resul);
            Console.WriteLine("Resultado de la suma de int: " + resul2);
            Console.Read();
        }
    }
}
