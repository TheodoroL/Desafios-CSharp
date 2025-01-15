var produto = new Produto("PS5", 5000, 3);

Console.WriteLine(produto.ValorTotalEstoque());

Console.WriteLine(produto.TemEstoque());


var produto2 = new Produto("Teclado", 150, 0);

Console.WriteLine(produto2.ValorTotalEstoque());
Console.WriteLine(produto2.TemEstoque());