class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public double Area()
    {
        return Altura * Largura;
    }
    public double Perimetro()
    {
        return 2 * (Altura + Largura);


    }

}