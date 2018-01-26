using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de una ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} bienvenido a {ciudad}");
            Console.ReadKey();

        }
    }
}
