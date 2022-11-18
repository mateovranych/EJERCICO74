using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICO74
{
    class Program
    {
        static void Main(string[] args)
        {
            String palabra;

            Stack pila_palabras = new Stack();
            Console.WriteLine("ingrese la primera palabra a la pila:");
            palabra = Console.ReadLine();

            while (palabra != "salir")
            {
                pila_palabras.Push(palabra);
                Console.WriteLine("Ingrese la próxima palabra, ingrese ¨salir¨ para salir");
                palabra = Console.ReadLine();
            }

            if (palabra == "salir")
            {
                Console.WriteLine("La pila generada es:");
            }

            while (pila_palabras.Count > 0)
            {

                string texto = (string)pila_palabras.Pop();
                Console.WriteLine(texto);
            }

            Console.ReadKey();


        }

    }
}