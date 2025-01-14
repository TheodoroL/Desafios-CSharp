class ContaBancaria
{
    public int NumeroConta;
    public string NomeTitular;
    public double Saldo { get; private set; }

    public ContaBancaria(int numeroConta, string nome, double saldo)
    {
        NumeroConta = numeroConta;
        NomeTitular = nome;
        Saldo = saldo;
    }

    public void SaqueDinheiro(double valor)
    {
        if (Saldo <= 0)
        {
            Console.WriteLine($"A conta está com saldo {Saldo.ToString("0.00")}. Desse modo não pode efetuar o saque");
            return;
        }
        Saldo -= valor;
        Console.WriteLine("Saque realizado com sucesso !!");
    }
    public void DepositoDinheiro(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Deposito realizado com o sucesso");
    }
}