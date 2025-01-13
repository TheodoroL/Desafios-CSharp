var livro = new Livro("livro teste", "daneo", DateTime.Now.Year);

Console.WriteLine(livro.Titulo);
Console.WriteLine(livro.Autor);
Console.WriteLine(livro.AnoPublicado);


livro.ExibirFormacoes();