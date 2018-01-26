using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del artículo");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el método de pago: efectivo o tarjeta");
            string mpago = (Console.ReadLine()).ToLower();

            if (mpago.Equals("efectivo"))
            {
                Console.WriteLine($"Se ha pagado el producto x con un precio de {price} mediante {mpago}");
                Console.ReadKey();
            }else if (mpago.Equals("tarjeta"))
            {
                Console.WriteLine("Por favor, introduce un número de cuenta");
                int n_cuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Se ha pagado el producto x con un precio de {price} mediante {mpago} con número de cuenta {n_cuenta}");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Método de pago incorrecto");
                Console.ReadKey();
            }
        }
    }
}
