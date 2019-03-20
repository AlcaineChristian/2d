using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio
{
    class Program
    {
        static int numero;
        static int mayor;
        static int menor;
        static int prom;
        static int sumaProm = 0;
        static int i;



        static void Main(string[] args)
        {
            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese numero :  \n");
                numero = int.Parse(Console.ReadLine());
                sumaProm = sumaProm + numero;
                if(i==0)
                    {
                        mayor = numero;
                        menor = numero;

                    }else if(numero>mayor)
                    {
                        mayor = numero;
                    }else if(numero<menor)
                    {
                        menor = numero;
                    }
            }
            prom = sumaProm / 5;
            Console.WriteLine("\nEl mayor es: ");
            Console.Write(mayor);
            Console.WriteLine("\nEl menor es: ");
            Console.Write(menor);
            Console.WriteLine("\nEl prom es: ");
            Console.Write(prom);
            Console.ReadKey();


        }

    }
}
