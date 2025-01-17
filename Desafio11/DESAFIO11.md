# Exercício 11
Você precisa criar um sistema de gerenciamento de uma biblioteca. O sistema deve ser
capaz de representar livros e leitores e permitir a realização de algumas operações
básicas.
Classes e Funcionalidades
1. Classe Livro
    - Atributos:
    - titulo (String)
    - autor (String)
    - anoPublicacao (int)
    -  disponivel (boolean)
o Métodos:
    -  Construtor para inicializar o título, autor, ano de publicação e
disponibilidade do livro.
    -  Métodos getters e setters para todos os atributos.
    -  emprestar() - Marca o livro como não disponível.
    -  devolver() - Marca o livro como disponível.
    -  toString() - Retorna uma representação textual do livro.

2. Classe Leitor
o Atributos:
    -  nome (String)
    -  livrosEmprestados (List<Livro>) - Lista de livros emprestados
pelo leitor
o Métodos:
    -  Construtor para inicializar o nome e a lista de livros emprestados.
    -  Métodos getters e setters para todos os atributos.
    -  emprestarLivro(Livro livro) - Adiciona um livro à lista de
livros emprestados e marca o livro como não disponível.
    -  devolverLivro(Livro livro) - Remove um livro da lista de
livros emprestados e marca o livro como disponível.
    -  toString() - Retorna uma representação textual do leitor.

3. Classe Biblioteca
o Atributos:
    -  livros (List<Livro>) - Lista de livros na biblioteca
    -  leitores (List<Leitor>) - Lista de leitores cadastrados
o Métodos:
    -  Construtor para inicializar as listas de livros e leitores.
    -  adicionarLivro(Livro livro) - Adiciona um livro à
biblioteca.
    -  adicionarLeitor(Leitor leitor) - Adiciona um leitor à
biblioteca.
    -  emprestarLivro(Leitor leitor, Livro livro) - Permite
que um leitor empreste um livro, se o livro estiver disponível.
    -  devolverLivro(Leitor leitor, Livro livro) - Permite que
um leitor devolva um livro.
    -  listarLivros() - Exibe todos os livros da biblioteca.
    -  listarLeitores() - Exibe todos os leitores da biblioteca.