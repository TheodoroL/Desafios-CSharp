class Produto
{
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }
    public string TemEstoque()
    {
        return Quantidade <= 0 ? "Não tem Estoque" : "Ainda tem estoque";
    }
}