using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase23A
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad { get; set; }
        public void Imprimir()
        {
            Console.WriteLine("El nombre ingresado es: " + Nombre + " y la edad es: " + Edad);
        }
    }
    public class Empleado: Persona
    {
        public double Sueldo { set; get; }
        public void ImprimirS()
        {
            Console.WriteLine("El sueldo es: " + Sueldo);
        }
    }
}
