using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un día de la semana");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                case "domindo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("No has introducido un día de la semana o no lo has escrito bien");
                    break;
            }
            Console.ReadKey();
        }
    }
}
