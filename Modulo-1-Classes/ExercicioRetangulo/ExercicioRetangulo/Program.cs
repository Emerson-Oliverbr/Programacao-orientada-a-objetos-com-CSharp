using System.Globalization;

namespace ExercicioRetangulo;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        Console.WriteLine("Entre com a largura e a altura do retangulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        retangulo.Largura = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Area = {retangulo.Area().ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Perímetro = {retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture)}");
    }
}

