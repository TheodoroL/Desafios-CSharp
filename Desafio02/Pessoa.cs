class Pessoa
{
    private string? _nome;
    public string? Nome { get => _nome; set => _nome = value; }
    private int _idade;
    public int Idade { get => _idade; set => _idade = value; }


    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }
    public Pessoa()
    {

    }

    public void Exibir()
    {
        Console.WriteLine($"Nome :{Nome} ");
        Console.WriteLine($"Idade :{Idade} ");

    }
    public void Aniversario()
    {
        _idade++;
    }
}