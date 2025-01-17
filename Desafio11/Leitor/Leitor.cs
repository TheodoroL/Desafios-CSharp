namespace Desafio11.Leitor;
using Desafio11.Livro;
public class Leitor
{
    public string Nome { get; set; } = string.Empty;
    public List<Livro> LivrosEmprestados { get; set; }

    public Leitor(string nome)
    {
        Nome = nome;
        LivrosEmprestados = [];
    }


    public void EmprestarLivro(Livro livro)
    {
        if (!livro.Disponivel)
        {
            Console.WriteLine($"O{livro.Titulo} não está disponivel");
            return;
        }

        livro.Emprestar();
        LivrosEmprestados.Add(livro);
    }

    public void DevolverLivro(Livro livro)
    {
        if (!LivrosEmprestados.Contains(livro))
        {
            Console.WriteLine($"O livro {livro.Titulo} não foi encontrado ");
            return;
        }
        LivrosEmprestados.Remove(livro);
        livro.Devolver();

    }

    public override string ToString()
    {
        return $"Leitor: {Nome}\nquantidade de Livro {LivrosEmprestados.Count}";
    }
}