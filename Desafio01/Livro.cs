class Livro
{

    private string? _titulo;
    public string? Titulo { get => _titulo; set => _titulo = value; }
    private string? _autor;
    public string? Autor { get => _autor; set => _autor = value; }

    private int _anoPublicado;
    public int AnoPublicado { get => _anoPublicado; set => AnoPublicado = value; }

    public Livro(string titulo, string autor, int anoPublicado)
    {
        _titulo = titulo;
        _autor = autor;
        _anoPublicado = anoPublicado;
    }

    public void ExibirFormacoes()
    {
        Console.WriteLine($@"
        -----------------------------
        Titulo do Livro: {Titulo}
        Autor: {Autor}
        ano Publicado: {AnoPublicado}
        -----------------------------

        ");
    }
}