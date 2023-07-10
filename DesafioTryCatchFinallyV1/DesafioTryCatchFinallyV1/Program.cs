using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTryCatchFinallyV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingresa un número para iniciar la división");
            string num1 = Console.ReadLine();
            int num1M = int.Parse(num1);
            Console.WriteLine("Por favor ingrese otro número para completar la división");
            string num2 = Console.ReadLine();
            int num2M = int.Parse(num2);

            try
            {
                int division1 = num1M / num2M;
                Console.WriteLine("El resultado es {0}", division1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Estas loco, no se puede dividir entre cero");
            }
        
            Console.Read();

        }
        
    }
}
