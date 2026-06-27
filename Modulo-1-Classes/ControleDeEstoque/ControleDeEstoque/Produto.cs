using System.Globalization;

namespace ControleDeEstoque;
public class Produto
{
    public string? Nome;
    public double Preco;
    public int Quantidade;

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