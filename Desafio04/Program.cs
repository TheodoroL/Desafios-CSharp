ContaBancaria contaBancaria = new(1, "Lucas", 30);

contaBancaria.SaqueDinheiro(20);

Console.WriteLine(contaBancaria.Saldo);

contaBancaria.SaqueDinheiro(10);
Console.WriteLine(contaBancaria.Saldo);

contaBancaria.SaqueDinheiro(10);
Console.WriteLine(contaBancaria.Saldo);

contaBancaria.SaqueDinheiro(10);
contaBancaria.SaqueDinheiro(10);
contaBancaria.SaqueDinheiro(10);
contaBancaria.SaqueDinheiro(10);
Console.WriteLine(contaBancaria.Saldo);


//  parte de Deposito
contaBancaria.DepositoDinheiro(7000);
Console.WriteLine(contaBancaria.Saldo);

