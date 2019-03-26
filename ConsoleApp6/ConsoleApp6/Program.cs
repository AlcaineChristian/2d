using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static float notaUno;
        static float notaDos;
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Alcaine", "Tomas",1848);
            Alumno alumno2 = new Alumno("Garaban", "Cristian",1849);
            Alumno alumno3 = new Alumno("FE", "FA",1850);
            Console.WriteLine("Ingrese notas de " + alumno1.nombre + alumno1.apellido);
            notaUno = float.Parse(Console.ReadLine());
            notaDos = int.Parse(Console.ReadLine());
            alumno1.Estudiar(notaUno, notaDos);
            alumno1.CalcularFinal();
            Console.WriteLine("Ingrese notas de " + alumno2.nombre + alumno2.apellido);
            notaUno = int.Parse(Console.ReadLine());
            notaDos = int.Parse(Console.ReadLine());
            alumno2.Estudiar(notaUno, notaDos);
            alumno2.CalcularFinal();
            Console.WriteLine("Ingrese notas de " + alumno3.nombre + alumno3.apellido);
            notaUno = int.Parse(Console.ReadLine());
            notaDos = int.Parse(Console.ReadLine());
            alumno3.Estudiar(notaUno, notaDos);
            alumno3.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();


        }
    }
}

