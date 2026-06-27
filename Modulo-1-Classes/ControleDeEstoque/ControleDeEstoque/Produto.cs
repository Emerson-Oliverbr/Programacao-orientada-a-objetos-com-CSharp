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

    public override string ToString()
    {
        return $"{Nome} R$ preço R$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}";
    }
}