using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerEjercicio
{
    class Program
    {
        static int numero;
        static int i;
        static int j;
        static int cantidad;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("1");
            for (i=1;i<=numero;i++)
            {
                cantidad = 0;

                for (j=1;j<=i;j++)
                {
                    if (i % j == 0)
                    {
                        cantidad++;
                    }
                }
                if(cantidad==2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(i);

                }

            }
            Console.ReadKey();

        }
    }
}
