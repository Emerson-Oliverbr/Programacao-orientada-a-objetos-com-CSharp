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
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);
            Console.WriteLine($"Dados atualizados: {produto}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("Digite o numero de produtos a serem removidas do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtde);
            Console.WriteLine($"Dados atualizados: {produto}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }
