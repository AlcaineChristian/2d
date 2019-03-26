using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    { 
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Alcaine", "Tomas",1848);
            Alumno alumno2 = new Alumno("Garaban", "Cristian",1849);
            Alumno alumno3 = new Alumno("FE", "FA",1850);
            //Alumno.colegio = "TSP";
            alumno1.Estudiar(6, 9);
            alumno1.CalcularFinal();
            alumno2.Estudiar(3, 9);
            alumno2.CalcularFinal();
            alumno2.Estudiar(6, 2);
            alumno2.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();


        }
    }
}

