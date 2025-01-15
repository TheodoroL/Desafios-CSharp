class Funcionario
{
    public string Nome { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;

    public double Salario { get; set; }

    public Funcionario(string nome, string cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }


    private double CalcularInss()
    {

        if (Salario <= 1320) return Salario * 0.075;
        else if (Salario <= 2571.29) return Salario * 0.09;
        else if (Salario <= 3856.94) return Salario * 0.12;
        else return Salario * 0.14;
    }

    private double CalcularIrrf()
    {
        double baseIrrf = Salario - CalcularInss();

        if (baseIrrf <= 1903.98) return 0;
        else if (baseIrrf <= 2826.65) return baseIrrf * 0.075 - 142;
        else if (baseIrrf <= 3751.05) return baseIrrf * 0.15 - 354;
        else if (baseIrrf <= 4664.68) return baseIrrf * 0.225 - 636.13;
        else return baseIrrf * 0.275 - 869.36;

    }


    public double SalarioLiquido()
    {
        double desconto = CalcularInss() + CalcularIrrf();
        return Salario - desconto;
    }
}