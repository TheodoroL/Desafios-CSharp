class Carro
{
    public string Marca { get; private set; } = string.Empty;
    public string Modelo { get; private set; } = string.Empty;
    public int Velocidade { get; private set; }


    public Carro(string marca, string modelo, int velocidade)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidade = velocidade;

    }

    public void Acelerar(int adicionarVelocidade)
    {
        if (adicionarVelocidade < 0)
        {
            Console.WriteLine("Não pode ser valor negativo");
            return;
        }
        Velocidade += adicionarVelocidade;
        Console.WriteLine($"{Modelo} aumentou a velocidade para {Velocidade}km/hr");
    }
    public void Freiar(int removerVelocidade)
    {
        if (removerVelocidade < 0)
        {
            Console.WriteLine("não da para remover com número negativo");
            return;
        }
        Velocidade -= removerVelocidade;
        if (Velocidade < 0)
        {
            Velocidade = 0;
        }
        Console.WriteLine($"{Modelo} freiou e a velocidade foi  para {Velocidade}km/hr");


    }
    public void ExibirVelocidade()
    {
        Console.WriteLine(Velocidade);
    }

}