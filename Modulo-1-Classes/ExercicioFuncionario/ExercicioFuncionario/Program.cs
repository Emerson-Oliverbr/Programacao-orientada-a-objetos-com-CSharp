using System.Globalization;
namespace ExercicioFuncionario;

class Program
{
    static void Main(String[] args)
    {
        Funcionario funcionario = new Funcionario();
        
        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Salario bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine()?? "0", CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        Console.WriteLine();
        Console.WriteLine($"Funcionario: {funcionario}");
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine()?? "0", CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(porcentagem);
        Console.WriteLine($"Dados atualizados: {funcionario}");
    }
}