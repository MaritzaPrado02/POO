using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoConsola4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Ingrese un numero: ");
            a = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            c = a + b;

            Console.WriteLine("La suma es: " + c);

            Console.ReadKey();

        }
    }
}
