using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCondicionalesV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor dime que temperatura actual");
            string laTemperatura = Console.ReadLine();
            int laTemperaturaNum = int.Parse(laTemperatura);

            if (laTemperaturaNum >= 22)
            {
                Console.WriteLine("Esta haciendo algo de calor sal en short");
            }
            else if (laTemperaturaNum <= 21)
            {
                Console.WriteLine("Esta haciendo frio abrigate si o si");
            }
            Console.Read();
        }
    }
}
