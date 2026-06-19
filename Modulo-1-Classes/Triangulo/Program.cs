using System.Globalization;

namespace Triangulo;
class Program 
{
    static void Main (string[] args) 
    {
        Triangulo trianguloX = new Triangulo();  
        Triangulo trianguloY = new Triangulo();        

        Console.WriteLine("Entre com as medidas do triangulo X: ");
        trianguloX.A = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        trianguloX.B = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        trianguloX.C = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        Console.WriteLine("");
        Console.WriteLine("Entre com as medidas do triangulo Y: ");
        trianguloY.A = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        trianguloY.B = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        trianguloY.C = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
        Console.WriteLine("-------------------");

        double p = (trianguloX.A + trianguloX.B + trianguloX.C) / 2.0;
        double areaX = Math.Sqrt(p * (p - trianguloX.A) * (p - trianguloX.B) * (p - trianguloX.C));

        p = (trianguloY.A + trianguloY.B + trianguloY.C) / 2.0;
        double areaY = Math.Sqrt(p * (p - trianguloY.A) * (p - trianguloY.B) * (p - trianguloY.C));

        Console.WriteLine($"Area de x = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Area de y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

        if(areaX > areaY)
        {
            Console.WriteLine("Maior area é: X");
        }
        else
        {
            Console.WriteLine("Maior area é: Y");
        }
    }
}
