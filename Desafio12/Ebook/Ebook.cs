namespace Desafio12.Ebook;
using Desafio12.Livro;
public class Ebook : Livro
{
    public float TamanhoArquivo { get; set; }

    public Ebook(string nome, string autor, float tamanhoArquivo) : base(nome, autor)
    {
        TamanhoArquivo = tamanhoArquivo;

    }

    public override void ExibirInformacao()
    {
        Console.WriteLine($"Titulo:{Titulo}\nAutor:{Autor}\nTamanho do Arquivo:{TamanhoArquivo}mb");

    }
}