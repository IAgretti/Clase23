namespace Clase23A
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Edificio e1 = new Edificio();
            Edificio e2 = new Edificio(5, 15);
            Edificio e3 = new Edificio(2.5, 5.3);
            Console.WriteLine($"El edificio tiene {e1.pisos} pisos y {e1.ocupantes} ocupantes.");
            Console.WriteLine($"El edificio tiene {e2.pisos} pisos y {e2.ocupantes} ocupantes.");
            Console.WriteLine($"El edificio tiene {e3.pisos} pisos y {e3.ocupantes} ocupantes.");
            //Persona p = new Persona();
            //p.Nombre = "Enrique";
            //p.Edad = 23;
            //p.Imprimir();
            //Empleado e = new Empleado();
            //e.Sueldo = 135500;
            //e.ImprimirS();
            Console.ReadKey();
        }
    }
}