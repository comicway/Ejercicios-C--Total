using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIFAutos
{
    internal class Program
    {
        static int numberCar;
        static void Main(string[] args)
        {
            dataUser();
            respuesta();
            Console.Read();
        }

        public static void dataUser()
        {
            Console.WriteLine("¿Cuantos carros usted posee?");
            string numberCar0 = Console.ReadLine();
            numberCar = Int32.Parse(numberCar0);
        }
        public static void respuesta()
        {

            if (numberCar == 0)
            {
                Console.WriteLine("Usted es pobre no tiene carro, por favor largo de aquí");
            } 
            else if (numberCar > 0)
            {
                int resultado = numberCar * 15;
                Console.WriteLine("Ustede debe pagar ${0} dolares de impuesto", resultado);
            }
        }
    }
}
