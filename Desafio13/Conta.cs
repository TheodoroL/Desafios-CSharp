class Conta
{
    public int NumeroConta { get; set; }

    public double Saldo { get; set; }


    public Conta(int numeroConta, double saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;

    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depositado Com sucesso ");
    }

    public void Sacar(double valor)
    {
        if (Saldo <= 0)
        {
            Console.WriteLine("Não é possivel sacar o seu dinheiro, pois o saldo está menor ou igual a zero");
            return;
        }
        Saldo -= valor;
        Console.WriteLine($"Saque realizado com sucesso, agora o seu saldo está {Saldo}");
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"O seu saldo está {Saldo}");
    }

}