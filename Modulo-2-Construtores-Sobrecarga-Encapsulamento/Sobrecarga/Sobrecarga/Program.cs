using System.Globalization;

namespace ControleDeEstoque;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        
        Produto produto = new Produto(nome, preco);
        
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
