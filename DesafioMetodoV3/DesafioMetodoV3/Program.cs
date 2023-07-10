using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMetodoV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string amigo1 = "Pablo";
            string amigo2 = "Daniel";
            string amigo3 = "Lucas";

            saludarAmigo(amigo1, amigo2, amigo3);
            Console.Read();
        }

        public static void saludarAmigo(string nombreAmigo1, string nombreAmigo2, string nombreAmigo3)
        {
            Console.WriteLine("¡Hola " + nombreAmigo1 + ", que tengas un buen día!");
            Console.WriteLine("¡Hola " + nombreAmigo2 + ", que tengas un buen día!");
            Console.WriteLine("¡Hola " + nombreAmigo3 + ", que tengas un buen día!");
        }
    }
}
