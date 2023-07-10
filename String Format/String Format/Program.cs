using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En C# el metodo String.Format se utiliza para  insertar el objeto o el valor
            // de la variable en otro string
            // Con Sting.Format podemos reemplazar el valor en el formato especificado
            string nombre = "Moises";
            var stringformat = String.Format("Mi nombre es {0}",nombre);
            Console.WriteLine(stringformat);
            Console.Read();
        }
    }
}
