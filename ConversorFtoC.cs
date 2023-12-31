//Variável onde será armazenada nome do usuário
string usuario;

Console.WriteLine("Informe seu nome por gentileza:");
usuario = Console.ReadLine();
Console.Clear();

//Apresentação do usuário seguido de tempo de 2segundos de espera para apresentação do conversor
Console.WriteLine($"Bem vindo {usuario}\n");
Thread.Sleep(2000);

//Inicio da repetição
while (true)
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗██╗░░░██╗███████╗██████╗░░██████╗░█████╗░██████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║██║░░░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║╚██╗░██╔╝█████╗░░██████╔╝╚█████╗░██║░░██║██████╔╝  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░╚████╔╝░██╔══╝░░██╔══██╗░╚═══██╗██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░╚██╔╝░░███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

███████╗░█████╗░██╗░░██╗██████╗░███████╗███╗░░██╗██╗░░██╗███████╗██╗████████╗  ██████╗░░█████╗░██████╗░░█████╗░
██╔════╝██╔══██╗██║░░██║██╔══██╗██╔════╝████╗░██║██║░░██║██╔════╝██║╚══██╔══╝  ██╔══██╗██╔══██╗██╔══██╗██╔══██╗
█████╗░░███████║███████║██████╔╝█████╗░░██╔██╗██║███████║█████╗░░██║░░░██║░░░  ██████╔╝███████║██████╔╝███████║
██╔══╝░░██╔══██║██╔══██║██╔══██╗██╔══╝░░██║╚████║██╔══██║██╔══╝░░██║░░░██║░░░  ██╔═══╝░██╔══██║██╔══██╗██╔══██║
██║░░░░░██║░░██║██║░░██║██║░░██║███████╗██║░╚███║██║░░██║███████╗██║░░░██║░░░  ██║░░░░░██║░░██║██║░░██║██║░░██║
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░███████╗██╗░░░░░░██████╗██╗██╗░░░██╗░██████╗
██╔══██╗██╔════╝██║░░░░░██╔════╝██║██║░░░██║██╔════╝
██║░░╚═╝█████╗░░██║░░░░░╚█████╗░██║██║░░░██║╚█████╗░
██║░░██╗██╔══╝░░██║░░░░░░╚═══██╗██║██║░░░██║░╚═══██╗
╚█████╔╝███████╗███████╗██████╔╝██║╚██████╔╝██████╔╝
░╚════╝░╚══════╝╚══════╝╚═════╝░╚═╝░╚═════╝░╚═════╝░");


    Console.WriteLine("\n\nDigite o valor para conversão: ");

    //Variáveis
    string input = Console.ReadLine();
    int fahrenheit = int.Parse(input);
    int result = (fahrenheit - 32) * 5 / 9;
    
    //Tempo de espera de 1segundo para executar resultado
    Thread.Sleep(1000);

    //Resultado da entrada do valor int feito pelo usuários
    Console.WriteLine($"\nO resultado da sua conversão é {result}Cº\n");

    //Condições para apresentar mensagem de acordo com a temperatura
    if (result >= 39)
    {
        Console.WriteLine("Está muito quente");
        if (result == 100)
        {
            Console.WriteLine($"\n{usuario} sabia que esta é a temperatura de ebolição da água no nível do mar?");
        }
    }
    else if (result <= 15)
    {
        Console.WriteLine("Está muito frio");
        if (result == 0)
        {
            Console.WriteLine($"\n{usuario}, sabia que esta é a temperatura de congelamento da água ao nível do mar?");
        }
    }
    else if (result > 16 && result < 38)
    {
        Console.WriteLine("É uma temperatura agradável");
        if (result == 37)
        {
            Console.WriteLine("\nSabia que está é a temperatura corporal média para humanos?");
        }
    }

    //Fim da mensagem para dar continuidade
    Console.WriteLine("\nPressione qualquer tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}
// Gerado apenas para loop sem opção de encerrar via comando