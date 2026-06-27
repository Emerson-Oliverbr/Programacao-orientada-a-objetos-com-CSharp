using System.Globalization;

namespace ControleDeEstoque;

    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine()??"0");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Dados do produto: {produto }");
        }
    }
