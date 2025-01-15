class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public int Matricula { get; set; }
    public double[] Notas { get; set; } = new double[3];

    public Aluno(string nome, int matricula, double[] notas)
    {
        Nome = nome;
        Matricula = matricula;
        Notas = notas;
    }

    public string Media()
    {
        double media = 0;

        foreach (var nota in Notas)
        {
            media += nota;
        }
        return media / Notas.Length < 7 ? $" Aluno {Nome} foi reprovado" : $" Aluno {Nome} foi aprovado";
    }
}


