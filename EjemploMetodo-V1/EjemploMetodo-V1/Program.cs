using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodo_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //texto1();
            //texto2("Esto es un argumento bien perrondo");
            Console.WriteLine(multiplica(3,5));
            Console.Read();
        }

        // Nivel de acceso - (static) - Tipo de retorno - Nombre del metodo (parametro1, parametro2)
        public static void texto1() {

            Console.WriteLine("Yo naci en un metodo");
            //Console.Read();
        }
        public static void texto2(string aquiElTexto) {

            Console.WriteLine(aquiElTexto);
            //Console.Read();
        }

        public static int multiplica(int num1, int num2) { 
        
            return num1 * num2;
        }
    }
}
