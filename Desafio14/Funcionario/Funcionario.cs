namespace Desafio14.Funcionario;

public class Funcionario
{
    public string Nome { get; private set; } = string.Empty;
    public decimal Salario { get; private set; }
    public Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salario = salario;
    }
    public decimal CalcularSalarioAnual() => Salario * 12;

    public void AumentarSalario(decimal porcentagem)
    {
        Salario += ((Salario * porcentagem) / 100);

        Console.WriteLine(Salario);
    }
}