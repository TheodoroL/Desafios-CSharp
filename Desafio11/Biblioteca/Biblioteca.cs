namespace Desafio11.Biblioteca;
using Desafio11.Livro;
using Desafio11.Leitor;
public class Biblioteca
{
    private List<Livro> _livros;
    private List<Leitor> _leitor;

    public Biblioteca()
    {
        _livros = [];
        _leitor = [];
    }

    public void AdicionarLeitor(Leitor leitor)
    {
        if (_leitor.Contains(leitor))
        {
            Console.WriteLine("leitor existente");
            return;
        }
        _leitor.Add(leitor);
        Console.WriteLine("Leitor adicionado no sistema");
    }
    public void AdicionarLivro(Livro livro)
    {
        _livros.Add(livro);
        Console.WriteLine("Adicionado no sistema com sucesso");
    }
    public void EmprestarLivro(Leitor leitor, Livro livro)
    {
        if (!_leitor.Contains(leitor) || !_livros.Contains(livro) || !livro.Disponivel)
        {
            Console.WriteLine("Não foi possivel Emprestar o Livro, verifica o leitor e o livro se está correto ou se o livro está disponivel ");
            return;
        }
        leitor.EmprestarLivro(livro);
        Console.WriteLine("O livro foi emprestado com sucesso");

    }
    public void DevolverLivro(Leitor leitor, Livro livro)
    {
        if (_leitor.Contains(leitor) && _livros.Contains(livro))
        {

            Console.WriteLine("Não foi possivel Emprestar o Livro, verifica o leitor e o livro se está correto");
            return;
        }
        leitor.DevolverLivro(livro);
        Console.WriteLine("O livro foi devolvido com sucesso");

    }
    public void ListarLivros()
    {
        Console.WriteLine("Listantando Livros");
        foreach (var l in _livros)
        {
            Console.WriteLine(l);
        }
    }
    public void ListarLeitores()
    {
        Console.WriteLine("Listantando Leitores");
        foreach (var l in _leitor)
        {
            Console.WriteLine(l);
        }
    }
}