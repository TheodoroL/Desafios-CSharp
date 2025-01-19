var conta = new ContaCorrente(12345, 1000, 500);
conta.Depositar(200);
conta.ConsultarSaldo();

conta.SacarChequeEspecial(1300);

conta.ConsultarSaldo();
Console.WriteLine($"{conta.ConsultarLimiteDisponivel()}");

conta.CobrarJurosChequeEspecial(5);
conta.ConsultarSaldo();
