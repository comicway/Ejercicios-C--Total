using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMetodoV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            amigoUno("Hola Jose");
            amigoDos("Hola Alfredo");
            amigoTres("Hola Daniel");

        }

        // Nivel de acceso - (static) - Tipo de retorno - Nombre del metodo (parametro1, parametro2)
        public static void amigoUno(string nombre1)
        {

            Console.WriteLine(nombre1);
            
        }

        public static void amigoDos(string nombre2)
        {

            Console.WriteLine(nombre2);
            
        }

        public static void amigoTres(string nombre2)
        {

            Console.WriteLine(nombre2);
            Console.Read();
        }
    }
}
