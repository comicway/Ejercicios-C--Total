using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversión explicita
            double miDouble = 13.37;
            int miInt;

            miInt = (int)miDouble;

            //comversión implicita
            int num = 123456;
            long numg = num;

            //conversión de tipo
            string miString = miDouble.ToString();
            bool elSolBrilla = true;
            string miBoolString = elSolBrilla.ToString();

            Console.WriteLine("Esta en la conversión explicita: " + miInt);
            Console.WriteLine("Esta es la conversión implicita: " + numg);
            Console.WriteLine("Esta es la conversión de tipo: " + miString);
            Console.WriteLine("Esta es la conversión de tipo: " + miBoolString);
            Console.Read();
        }
    }
}
