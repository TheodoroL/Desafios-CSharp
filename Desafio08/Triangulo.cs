class Triangulo
{
    public int LadoA { get; set; }
    public int LadoB { get; set; }
    public int LadoC { get; set; }


    public Triangulo(int a, int b, int c)
    {
        LadoA = a;
        LadoB = b;
        LadoC = c;
    }

    public string IsTriangulo()
    {

        if ((LadoB - LadoC < LadoA && LadoA < LadoB + LadoC) &&
        ((LadoA - LadoC < LadoB) && (LadoB < LadoA + LadoC)) &&
        ((LadoA - LadoB < LadoC) && (LadoC < LadoA + LadoB)))
            return "É triângulo valido";
        else return "Não é um triângulo valido";
    }
}