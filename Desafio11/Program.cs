using Desafio11.Biblioteca;
using Desafio11.Leitor;
using Desafio11.Livro;

var biblioteca = new Biblioteca();

var leitor = new Leitor("Lucas");
var livro = new Livro("Teste", "teste", new Random().Next(1000, 2025), true);

biblioteca.AdicionarLeitor(leitor);
biblioteca.AdicionarLivro(livro);

biblioteca.EmprestarLivro(leitor, livro);
biblioteca.EmprestarLivro(leitor, livro);

biblioteca.ListarLeitores();
biblioteca.ListarLivros();