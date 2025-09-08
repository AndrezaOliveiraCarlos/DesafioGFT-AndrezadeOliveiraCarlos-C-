using exercicio2;

int continuar = 1;
List<Reserva> reservas = new List<Reserva>();

while (continuar == 1)
{
    Console.WriteLine("Digite uma opção: \n 1 - Cadastrar Reserva\n 2 - Exibir Reservas");
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {

        Reserva objReserva = new Reserva();
        Console.WriteLine("Digite o nome da reserva");
        objReserva.Nome = Console.ReadLine();
        Console.WriteLine("Digite o horario da reserva");
        objReserva.Hora = Console.ReadLine();

        bool existeReserva = false;

        foreach (var item in reservas)
        {
            if (item.Nome == objReserva.Nome && item.Hora == objReserva.Hora)
            {
                existeReserva = true;
            }
        }

        if (existeReserva)
        {
            Console.WriteLine("Erro, já existe uma reserva para esta sala neste horario");
        }
        else
        {
            reservas.Add(objReserva);
        }
    }
    else if (opcao == 2)
    {
        foreach (var item in reservas)
        {
            Console.WriteLine($"Sala:{item.Nome} Hora: {item.Hora}");
        }
    }

    Console.WriteLine("Deseja continuar: \n 1 - Sim\n 2 - Não");
    continuar = int.Parse(Console.ReadLine());
}