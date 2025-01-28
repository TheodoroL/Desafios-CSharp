namespace Desafio14.Gerente;
using Desafio14.Funcionario;
public class Gerente : Funcionario
{
    public decimal Bonus { get; private set; }
    public int FuncionariosGerenciados { get; private set; }
    public Gerente(string nome, decimal salario, decimal bonus, int funcionariosGerenciados) : base(nome, salario)
    {
        Bonus = bonus;
        FuncionariosGerenciados = funcionariosGerenciados;

    }
    public decimal CalcularSalarioAnualBonus() => CalcularSalarioAnual() + CalcularSalarioAnual() * (Bonus / 100m);

    public void AdicionarFuncionarioGerenciado(int funcionario)
    {
        FuncionariosGerenciados += funcionario;

    }

    public void RemoverFuncinarioGerenciado(int funcionario)
    {
        if (FuncionariosGerenciados <= 0 || FuncionariosGerenciados < funcionario)
        {
            Console.WriteLine("Não é possivel remover funcionario, pois está menor ou igual a zero");
            return;
        }
        FuncionariosGerenciados -= funcionario;
    }
}