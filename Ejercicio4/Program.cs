using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            if(num2 >= num1)
            {
                Console.WriteLine("El segundo número es mayor o igual que el primero");
            }
            else
            {
                Console.WriteLine("El primer número es mayor que el segundo");
            }
            Console.ReadKey();
        }
    }
}
