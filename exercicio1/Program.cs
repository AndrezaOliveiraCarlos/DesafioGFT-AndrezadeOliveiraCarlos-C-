Console.WriteLine("Digite a quantidade de dias de estudos:");
int qtdDias = int.Parse(Console.ReadLine());

if (qtdDias <= 7)
{

    int qtdHoras = 0;
    int[] vetHorasPorDia = new int[qtdDias];
    int media = 0;
    string horas = "";
    for (int i = 0; i < qtdDias; i++)
    {
        Console.WriteLine("Digite a quantidade horas estudadas do dia:");
        string h =  Console.ReadLine();
        vetHorasPorDia[i] += int.Parse(h);
        qtdHoras += vetHorasPorDia[i];
        horas += h;
    }

    media = qtdHoras / qtdDias;

    Console.WriteLine($"Dias de estudo: {qtdDias}");
    Console.WriteLine($"Horas: {qtdDias}");
    Console.WriteLine($"Total de horas: {horas}");
    Console.WriteLine($"Media {media} horas/dia");

    if (media >= 20)
    {
        Console.WriteLine($"Media atingida");
    }
    else
    {
        Console.WriteLine($"Media não atingida");
    }

}
else
{
    Console.WriteLine("Erro! O numero maximo de dias de estudo é 7");
}