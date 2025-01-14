class Circulo
{
    public double Raio { get; set; }

    public double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
}