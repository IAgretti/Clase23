namespace Clase23
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Suma s = new Suma();
            s.Valor1 = 10;
            s.Valor2 = 7;
            s.Operar();
            Console.WriteLine("La suma de " + s.Valor1 + " y " + s.Valor2 + " es " + s.Resultado + ".");
            Resta r = new Resta();
            r.Valor1 = 8;
            r.Valor2 = 4;
            r.Operar();
            Console.WriteLine("La resta de " + r.Valor1 + " y " + r.Valor2 + " es " + r.Resultado + ".");
            Console.ReadKey();
        }
    }
}