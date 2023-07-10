using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_tipo_datos_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteEj = 255;
            Console.WriteLine("Tipo Byte: " + byteEj);
            sbyte sbyteEj = -128;
            Console.WriteLine("Tipo SByte: " + sbyteEj);
            int intEj = -2147483647;
            Console.WriteLine("Tipo Int: " + intEj);
            uint uintEj = 4294967295;
            Console.WriteLine("Tipo Uint: " + uintEj);
            
            Console.WriteLine("Ingrese tu número de la suerte");
            string numeroSuerte = Console.ReadLine();
            int numeroCambiado = Int32.Parse(numeroSuerte);
            Console.WriteLine("Coloca 1 si ese es tu número: {0}", numeroCambiado + " Coloca 2 si no es tu numero");
            string respuesta = Console.ReadLine();
            int respuestaCambiada = Int32.Parse(respuesta);
            if (respuestaCambiada == 1) {
                Console.WriteLine("Estas en lo correcto");
            }
            else {
                Console.WriteLine("Eres un mentiroso");
            }
            Console.Read();
        }
    }
}
