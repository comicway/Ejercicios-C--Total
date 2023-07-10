using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeclaracionesIFV2
{
    internal class Program
    {

        static string nombreJugador;
        static int puntajeJugador2;
        static void Main(string[] args)
        {

            IngresarDatos();
            CompararDatos(nombreJugador, puntajeJugador2);
            Console.Read();
        }
        public static void IngresarDatos()
        {
            Console.WriteLine("Por favor introduzca el nombre del jugador");

            nombreJugador = Console.ReadLine();

            Console.WriteLine("Ahora introduce el puntaje del jugador {0}", nombreJugador);

            string puntajeJugador = Console.ReadLine();

            puntajeJugador2 = Int32.Parse(puntajeJugador);

        }
        public static void CompararDatos(string nombreJugador, int puntajeJugador2)
        {
            string jugadorRecord = "Marcos";
            int puntacionRecord = 5;

            if (puntajeJugador2 > puntacionRecord && nombreJugador != jugadorRecord)
            {
                Console.WriteLine("La nueva puntuación más alta es: " + puntajeJugador2);
                Console.WriteLine("La puntuación más alta fue lograda por: " + nombreJugador);
            }
            else
            {
                Console.WriteLine("La puntuación más alta de " + puntacionRecord + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
            }
        }
    }
}
