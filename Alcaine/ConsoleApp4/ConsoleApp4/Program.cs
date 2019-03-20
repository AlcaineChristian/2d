using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio
{
    class Program
    {
        static double numero;
        static double cuadrado;
        static double cubo;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese numero ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                    Console.WriteLine("ERROR. ¡Reingresar número!");
            } while (numero == 0);
            cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("\nSu cuadrado es :");
            Console.WriteLine(cuadrado);
            Console.WriteLine("\nSu cubo es :");
            Console.WriteLine(cubo);
            Console.ReadKey();
            

        }
    }
}
