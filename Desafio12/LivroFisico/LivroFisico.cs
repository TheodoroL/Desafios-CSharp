namespace Desafio12.LivroFisico;

using Desafio12.Livro;
class LivroFisico : Livro
{
    public int NumeroPagina { get; set; }

    public LivroFisico(string nome, string autor, int numeroPagina) : base(nome, autor)
    {
        NumeroPagina = numeroPagina;
    }

    public override void ExibirInformacao()
    {
        Console.WriteLine($"Titutlo:{Titulo}\nAutor:{Autor}\nNúmero de Página: {NumeroPagina}");
    }
}