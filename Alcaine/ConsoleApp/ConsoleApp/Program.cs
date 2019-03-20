using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  class Program
  {

    static int numUno;
    static int numDos;
    static int resultado;
    static int opcion;

    static void Main(string[] args)
    {
      Console.WriteLine("1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n");
      opcion = int.Parse(Console.ReadLine());
      Console.WriteLine("\nNumero1:  ");
      numUno = int.Parse(Console.ReadLine());
      Console.WriteLine("\nNumero2:  ");
      numDos = int.Parse(Console.ReadLine());
      miMetodo(opcion,numUno,numDos);
      Console.WriteLine("\nResultado :");
      Console.WriteLine(resultado);
      Console.ReadKey();

    }

    static void miMetodo(int operacion,int numeroUno,int numeroDos)
    {
      switch (operacion)
      {
        case 1:
          
          resultado = numeroUno + numeroDos;
         
          break;

        case 2:
          resultado = numeroUno - numeroDos;
          break;

        case 3:
          
          resultado = numeroUno * numeroDos;
          
          break;

        case 4:
          
          resultado = numeroUno / numeroDos;

          break;

      }

    }
  }
}
