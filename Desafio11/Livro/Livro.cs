namespace Desafio11.Livro;
public class Livro
{
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public int AnoPublicado { get; set; }
    public bool Disponivel { get; set; }

    public Livro(string titulo, string autor, int Ano, bool disponivel)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicado = Ano;
        Disponivel = disponivel;
    }

    public void Emprestar()
    {
        Disponivel = false;
    }

    public void Devolver()
    {
        Disponivel = true;
    }

    public override string ToString()
    {
        return $@"
            Titulo: {Titulo}
            Autor: {Autor}
            Ano Publicado: {AnoPublicado}
            está disponivel : {(Disponivel ? "Sim" : "Não")}
        ";
    }
}