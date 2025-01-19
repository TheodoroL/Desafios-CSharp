class ContaCorrente : Conta
{
    public double LimiteChequeEspecial { get; set; }

    public ContaCorrente(int numeroConta, double saldo, double limiteChequeEspecial) : base(numeroConta, saldo)
    {
        LimiteChequeEspecial = limiteChequeEspecial;
    }

    public void SacarChequeEspecial(double valor)
    {
        if (valor >= Saldo + LimiteChequeEspecial)
        {
            Console.WriteLine("Não é possivel sacar o cheque especial");
            return;
        }

        Saldo -= valor;
        Console.WriteLine($"Cheque utilizado com sucesso, o seu saldo está {Saldo}");

    }

    public double ConsultarLimiteDisponivel() => Saldo < 0 ? LimiteChequeEspecial + Saldo : LimiteChequeEspecial;

    public void CobrarJurosChequeEspecial(double taixaJuros)
    {
        if (Saldo < 0)
        {
            double juros = -Saldo * (taixaJuros / 100);
            Saldo -= juros;
            Console.WriteLine($"Juros de {juros:C} aplicados ao saldo negativo.");
        }
    }
}