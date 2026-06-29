using System.Globalization;

namespace ControleDeEstoque;
public class Produto
{
    public string? Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public double ValorTotalEmEstoque()
    {
        return Quantidade * Preco;
    }
    
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    public override string ToString()
    {
        return $"{Nome}, R$ preço R$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, " +
               $"Quantidade: {Quantidade}, Valor total em estoque {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}