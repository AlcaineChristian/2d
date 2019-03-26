using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Alumno
    {
        float nota1;
        float nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public static string colegio;

        public Alumno(string Apellido, string Nombre, int Legajo)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.legajo = Legajo;
            this.notaFinal = -1;
        }

        static Alumno()
        {
            colegio = "A.T.R";

        }

        public void CalcularFinal()
        {
            if(this.nota1>=4 && this.nota2>=4 )
            {
                this.notaFinal = (this.nota1 + this.nota2) / 2;
            }

        }
        public void Estudiar(float notaUno, float notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }
        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " - " + legajo + " - " + colegio + " - " + (this.notaFinal == -1 ? "DESAPROBADO" : this.notaFinal.ToString());
        }


    }
}
