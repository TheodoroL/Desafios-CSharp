namespace Desafio12.Livro;
public class Livro
{
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public virtual void ExibirInformacao()
    {
        Console.WriteLine($"Titulo:{Titulo}\nAutor:{Autor}");
    }
}