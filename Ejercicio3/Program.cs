using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");
            Console.ReadKey();
        }
    }
}
