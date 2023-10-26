using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase23
{
    public class Operacion
    {
        protected int valor1, valor2, resultado;

        public int Valor1
        {
            get 
            { 
                return valor1;
            }
            set 
            {
                valor1 = value;
            }
        }
        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public int Resultado { get; set; }

    }
    public class Suma: Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
       
    }
    public class Resta: Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }
}
