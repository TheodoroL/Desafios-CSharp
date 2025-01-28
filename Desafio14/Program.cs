using Desafio14.Funcionario;
using Desafio14.Gerente;

var funcionario = new Funcionario("Lucas", 1000);

Console.WriteLine(funcionario.CalcularSalarioAnual());
funcionario.AumentarSalario(50);


var gerente = new Gerente("Lucas", 3000, 12, 3);

Console.WriteLine(gerente.CalcularSalarioAnualBonus());

gerente.AdicionarFuncionarioGerenciado(3);

gerente.RemoverFuncinarioGerenciado(9);